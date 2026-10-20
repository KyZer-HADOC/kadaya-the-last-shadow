using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// Attach to a statue GameObject. Walk close and press E to hide; press E again to leave.
/// Mobile HUD Buttons can call OnInteractButton().
/// </summary>
[DisallowMultipleComponent]
public sealed class HideStatue : MonoBehaviour
{
    [Header("Player and hide points")]
    [Tooltip("Optional. If empty, the object tagged Player is used.")]
    public Transform player;
    [Tooltip("Optional child Transform where Kadaya waits while hidden.")]
    public Transform hideAnchor;
    [Tooltip("Optional safe spot where Kadaya appears when leaving.")]
    public Transform exitAnchor;

    [Header("Interaction")]
    [Min(0.25f)] public float interactDistance = 1.8f;
    public KeyCode interactKey = KeyCode.E;
    [Min(0.25f)] public float exitOffset = 1.25f;

    [Header("Optional prompt UI")]
    [Tooltip("Optional Unity UI Text. Leave empty for a custom HUD.")]
    public Text promptText;
    public string hidePrompt = "Press E to hide";
    public string exitPrompt = "Press E to leave";

    private KadayaHideState _playerState;

    private void Start()
    {
        ResolvePlayer();
        SetPrompt(false, string.Empty);
    }

    private void Update()
    {
        if (player == null || _playerState == null) ResolvePlayer();
        if (player == null || _playerState == null)
        {
            SetPrompt(false, string.Empty);
            return;
        }

        bool insideThisStatue = _playerState.IsHidden && _playerState.CurrentStatue == this;
        bool inRange = IsPlayerInRange();
        SetPrompt(insideThisStatue || (!_playerState.IsHidden && inRange),
            insideThisStatue ? exitPrompt : hidePrompt);

        if ((insideThisStatue || (!_playerState.IsHidden && inRange)) &&
            Input.GetKeyDown(interactKey))
            OnInteractButton();
    }

    private void ResolvePlayer()
    {
        if (player != null)
        {
            _playerState = player.GetComponent<KadayaHideState>();
            return;
        }

        try
        {
            GameObject taggedPlayer = GameObject.FindGameObjectWithTag("Player");
            if (taggedPlayer != null) player = taggedPlayer.transform;
        }
        catch (UnityException)
        {
            // If the tag is not defined, fall back to finding the state component.
        }

        if (player == null)
        {
#if UNITY_2023_1_OR_NEWER
            _playerState = FindFirstObjectByType<KadayaHideState>();
#else
            _playerState = FindObjectOfType<KadayaHideState>();
#endif
            if (_playerState != null) player = _playerState.transform;
        }
        else
        {
            _playerState = player.GetComponent<KadayaHideState>();
        }
    }

    private bool IsPlayerInRange()
    {
        if (player == null) return false;
        Vector2 a = new Vector2(player.position.x, player.position.y);
        Vector2 b = new Vector2(transform.position.x, transform.position.y);
        return Vector2.Distance(a, b) <= interactDistance;
    }

    /// <summary>Connect a mobile HUD Button to this public method.</summary>
    public void OnInteractButton()
    {
        if (player == null || _playerState == null) ResolvePlayer();
        if (player == null || _playerState == null) return;

        if (_playerState.IsHidden)
        {
            if (_playerState.CurrentStatue != this) return;
            Vector3 exitPosition = exitAnchor != null
                ? exitAnchor.position
                : transform.position + transform.right * exitOffset;
            _playerState.ExitStatue(this, exitPosition);
            return;
        }

        if (!IsPlayerInRange()) return;
        Vector3 hidePosition = hideAnchor != null ? hideAnchor.position : transform.position;
        _playerState.EnterStatue(this, hidePosition);
    }

    private void SetPrompt(bool visible, string message)
    {
        if (promptText == null) return;
        if (promptText.gameObject.activeSelf != visible)
            promptText.gameObject.SetActive(visible);
        if (visible) promptText.text = message;
    }

    private void OnDrawGizmosSelected()
    {
        Gizmos.color = new Color(0.7f, 0.1f, 0.1f, 1f);
        Gizmos.DrawWireSphere(transform.position, interactDistance);
    }
}
