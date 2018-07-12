using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAnimManager : MonoBehaviour {

    public void StartAttack()
    {

    }

    public void EndDamage()
    {

    }

    public void EndAttack()
    {
        Controller.SetAttackCooldown = Controller.AttackCooldown;
    }

}
