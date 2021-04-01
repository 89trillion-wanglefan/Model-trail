using UnityEngine;

/// <summary>
/// 士兵动画控制类
/// </summary>
public class InfantryControl : MonoBehaviour
{
    [SerializeField] private Animator infantryAnim;//士兵的动画机
    private static readonly int IsAttack = Animator.StringToHash("IsAttack");//预存动画机中的开关，提高效率
    private static readonly int IsIdle = Animator.StringToHash("IsIdle");
    private static readonly int IsRun = Animator.StringToHash("IsRun");

    void Update()
    {
        if(Input.GetKeyDown(KeyCode.A)) infantryAnim.SetTrigger(IsAttack);//按A时放攻击动画
        else if(Input.GetKeyDown(KeyCode.I)) infantryAnim.SetTrigger(IsIdle);//按I时放发呆动画
        else if(Input.GetKeyDown(KeyCode.R)) infantryAnim.SetTrigger(IsRun);//按R时放奔跑动画
        
    }
}
