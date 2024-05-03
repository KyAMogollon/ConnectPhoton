using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class Health : MonoBehaviour
{
    public int health;
    public int healthMax;
    public bool IsDead { get => (health <= 0); }
    public PhotonView PV;
    public Image HealthBarClone;
    public Image HealthBarLocal;
    public bool Importal = false;

    public virtual void LoadComponent()
    {
        health = healthMax;
        PV = GetComponent<PhotonView>();

    }
    // Start is called before the first frame update
    public virtual void ResetPlayer()
    {

    }
    public void UpdateHealthBarClone()
    {
        if (HealthBarClone != null)
        {
            float h = ((float)((float)health / (float)healthMax));
            HealthBarClone.fillAmount = h;
        }
    }
    public void UpdateHealthBarLocal()
    {

        if (HealthBarLocal != null)
        {
            float h = ((float)((float)health / (float)healthMax));
            HealthBarLocal.fillAmount = h;

        }
    }
    public virtual void Damage(int damage)
    {
        if (Importal) return;

        if (!IsDead)
        {
            if ((health - damage) > 0)
                health -= damage;
            else
                health = 0;
        }

    }
}
