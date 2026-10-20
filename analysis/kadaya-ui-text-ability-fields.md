# Kadaya UI text / ability serialized-field scan

Read-only scan of the original Unity serialized bundle. No game files or scene layouts were changed.

- Unity objects seen: 826,192
- MonoBehaviour objects: 36,364
- Distinct MonoBehaviour script classes: 202

## Object type counts
- GameObject: 278,620
- Transform: 265,898
- SpriteRenderer: 119,830
- MonoBehaviour: 36,364
- BoxCollider2D: 23,249
- ParticleSystem: 22,002
- ParticleSystemRenderer: 22,002
- RectTransform: 12,722
- CanvasRenderer: 12,619
- AudioSource: 6,557
- Animator: 4,950
- EdgeCollider2D: 4,712
- Rigidbody2D: 3,094
- CircleCollider2D: 2,314
- MonoScript: 1,817
- MeshRenderer: 1,706
- Sprite: 1,662
- TextMesh: 1,150
- TrailRenderer: 687
- PolygonCollider2D: 681
- MeshFilter: 557
- BoxCollider: 432
- Texture2D: 389
- LineRenderer: 331
- AudioClip: 314
- AnimationClip: 233
- Material: 221
- Canvas: 98
- CapsuleCollider2D: 92
- PreloadData: 90
- Camera: 89
- AudioListener: 89
- RenderSettings: 89
- FlareLayer: 89
- LightmapSettings: 89

## User-interface, story and gameplay-oriented script classes
- UnityEngine.UI.Text: 2225 instance(s); fields seen: 
- HUDTextChild: 1092 instance(s); fields seen: 
- ShowAndHide: 495 instance(s); fields seen: 
- HUDText: 252 instance(s); fields seen: 
- LevelBtn: 84 instance(s); fields seen: 
- PlayerDash: 84 instance(s); fields seen: 
- AudioPlayer: 84 instance(s); fields seen: 
- SkillButton: 50 instance(s); fields seen: 
- HideObj: 27 instance(s); fields seen: 
- UVTextureAnimator: 21 instance(s); fields seen: 
- SkillTree: 5 instance(s); fields seen: 
- LevelLeader: 2 instance(s); fields seen: 
- CotTruyenLeader: 2 instance(s); fields seen: 
- DisguiseManager: 1 instance(s); fields seen: 
- ShopPanel: 1 instance(s); fields seen: 
- StoryCanvas: 1 instance(s); fields seen: 
- EndGame: 1 instance(s); fields seen: 

## Serialized string fields matching story/ability text
- UnityEngine.GUISkin | unity default resources path_id=11000 | m_Name = GameSkin

## Read errors
- missing script pointer: 2

## Patch feasibility
- The scan distinguishes Unity UI Text/Dialogue classes from TextMesh strings so the next patch can edit only known user-facing fields.
- Since this is an IL2CPP build, the scan does not restore native gameplay method bodies. New ability mechanics are not claimed as implemented by text or texture edits.
- Playable scene/map/level layouts remain unchanged.
