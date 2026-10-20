using System;
using UnityEngine;

/// <summary>
/// Add to Kadaya's root Player object. Saves/restores the player state while concealed.
/// </summary>
[DisallowMultipleComponent]
public sealed class KadayaHideState : MonoBehaviour
{
    [Header("Disable these while hiding")]
    [Tooltip("Drag the player's movement, input, dash and attack scripts here. Do not add this component.")]
    public MonoBehaviour[] disableWhileHidden;

    public bool IsHidden { get; private set; }
    public HideStatue CurrentStatue { get; private set; }
    public static bool AnyPlayerHidden { get; private set; }
    public static event Action<KadayaHideState, bool> HiddenChanged;

    private Renderer[] _renderers;
    private bool[] _rendererWasEnabled;
    private Animator[] _animators;
    private bool[] _animatorWasEnabled;
    private bool[] _movementWasEnabled;
    private Rigidbody2D _body2D;
    private RigidbodyConstraints2D _body2DOriginalConstraints;
    private Rigidbody _body3D;
    private RigidbodyConstraints _body3DOriginalConstraints;
    private bool _physicsCached;

    private void Awake() { CachePlayerComponents(); }

    private void CachePlayerComponents()
    {
        if (_renderers == null)
        {
            _renderers = GetComponentsInChildren<Renderer>(true);
            _rendererWasEnabled = new bool[_renderers.Length];
            for (int i = 0; i < _renderers.Length; i++)
                _rendererWasEnabled[i] = _renderers[i] != null && _renderers[i].enabled;
        }

        if (_animators == null)
        {
            _animators = GetComponentsInChildren<Animator>(true);
            _animatorWasEnabled = new bool[_animators.Length];
            for (int i = 0; i < _animators.Length; i++)
                _animatorWasEnabled[i] = _animators[i] != null && _animators[i].enabled;
        }

        int count = disableWhileHidden == null ? 0 : disableWhileHidden.Length;
        if (_movementWasEnabled == null || _movementWasEnabled.Length != count)
        {
            _movementWasEnabled = new bool[count];
            for (int i = 0; i < count; i++)
                _movementWasEnabled[i] = disableWhileHidden[i] != null && disableWhileHidden[i].enabled;
        }

        if (!_physicsCached)
        {
            _body2D = GetComponent<Rigidbody2D>();
            _body3D = GetComponent<Rigidbody>();
            if (_body2D != null) _body2DOriginalConstraints = _body2D.constraints;
            if (_body3D != null) _body3DOriginalConstraints = _body3D.constraints;
            _physicsCached = true;
        }
    }

    public bool EnterStatue(HideStatue statue, Vector3 hidePosition)
    {
        if (statue == null || IsHidden) return false;
        CachePlayerComponents();
        transform.position = hidePosition;

        if (_body2D != null)
        {
            _body2D.velocity = Vector2.zero;
            _body2D.constraints = RigidbodyConstraints2D.FreezeAll;
        }
        if (_body3D != null)
        {
            _body3D.velocity = Vector3.zero;
            _body3D.angularVelocity = Vector3.zero;
            _body3D.constraints = RigidbodyConstraints.FreezeAll;
        }

        for (int i = 0; i < _movementWasEnabled.Length; i++)
        {
            MonoBehaviour behaviour = disableWhileHidden[i];
            if (behaviour == null || behaviour == this) continue;
            _movementWasEnabled[i] = behaviour.enabled;
            behaviour.enabled = false;
        }
        for (int i = 0; i < _animators.Length; i++)
        {
            if (_animators[i] == null) continue;
            _animatorWasEnabled[i] = _animators[i].enabled;
            _animators[i].enabled = false;
        }
        for (int i = 0; i < _renderers.Length; i++)
        {
            if (_renderers[i] == null) continue;
            _rendererWasEnabled[i] = _renderers[i].enabled;
            _renderers[i].enabled = false;
        }

        CurrentStatue = statue;
        IsHidden = true;
        AnyPlayerHidden = true;
        HiddenChanged?.Invoke(this, true);
        return true;
    }

    public bool ExitStatue(HideStatue statue, Vector3 exitPosition)
    {
        if (!IsHidden || CurrentStatue != statue) return false;
        transform.position = exitPosition;

        for (int i = 0; i < _renderers.Length; i++)
            if (_renderers[i] != null) _renderers[i].enabled = _rendererWasEnabled[i];
        for (int i = 0; i < _animators.Length; i++)
            if (_animators[i] != null) _animators[i].enabled = _animatorWasEnabled[i];
        for (int i = 0; i < _movementWasEnabled.Length; i++)
        {
            MonoBehaviour behaviour = disableWhileHidden[i];
            if (behaviour != null && behaviour != this)
                behaviour.enabled = _movementWasEnabled[i];
        }

        if (_body2D != null) _body2D.constraints = _body2DOriginalConstraints;
        if (_body3D != null) _body3D.constraints = _body3DOriginalConstraints;

        CurrentStatue = null;
        IsHidden = false;
        AnyPlayerHidden = false;
        HiddenChanged?.Invoke(this, false);
        return true;
    }

    /// <summary>Call before an enemy pursues or attacks a player target.</summary>
    public static bool IsHiddenTarget(Transform target)
    {
        if (target == null) return false;
        KadayaHideState state = target.GetComponentInParent<KadayaHideState>();
        return state != null && state.IsHidden;
    }

    private void OnDisable()
    {
        if (IsHidden && CurrentStatue != null)
            ExitStatue(CurrentStatue, transform.position);
    }
}
