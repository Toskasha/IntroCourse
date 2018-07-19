using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIAnimManager : MonoBehaviour {

    public AIMonsterController Controller;

    public GameObject Hitbox;

    public void StartAttack()
    {
        Hitbox.SetActive(true);
    }

    public void EndDamage()
    {
        Hitbox.SetActive(false);
    }

    public void EndAttack()
    {
        Controller.SetAttackCooldown = Controller.AttackCooldown;
    }

}
