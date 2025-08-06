using UnityEngine;

[CreateAssetMenu(fileName = "PorkData", menuName = "Scriptable Objects/PorkData")]
public class PorkData : ScriptableObject
{
    public float attackRange = 1f;
    public float attackDamage = 10f;
    public float runSpeed = 2f;
    public float attackDuration = 1f;
    public float attackCooldown = 1f;
    public string dieSoundName;
    public string attackSoundName = "PorkAttack";
    public string primaryTargetTag = "Tower";
    public string runAnimationName = "PorkRun";
    public string attackAnimationName = "PorkAttack";
    public string dieAnimationName = "PorkDie";
    public string winAnimationName = "PorkWin";
}
