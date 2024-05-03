using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;
public class HealthPlayer : Health
{
    Animator animator;
    CharacterController charactercontroller;
    //IKHuman _IKHuman;

    // Start is called before the first frame update
    void Start()
    {
        LoadComponent();
    }
    public override void LoadComponent()
    {
        base.LoadComponent();
        animator = GetComponent<Animator>();
        //collider = GetComponent<CapsuleCollider>();
        charactercontroller = GetComponent<CharacterController>();
        //_IKHuman = GetComponent<IKHuman>();


    }

    //void Die()
    //{
    //    health = 0;

    //    if (collider == null)
    //    {
    //        collider = GetComponent<CapsuleCollider>();
    //    }

    //    if (collider != null)
    //        collider.enabled = false;

    //    if (charactercontroller == null)
    //    {
    //        charactercontroller = GetComponent<CharacterController>();
    //    }

    //    if (charactercontroller != null)
    //        charactercontroller.enabled = false;

    //    _IKHuman.IKActive = false;
    //    //_WeaponManager.enabled = false;
    //    animator.SetBool("Die", true);
    //    Invoke("Active", 5);
    //    if (PV != null)
    //        PV.RPC("RPC_Die", RpcTarget.All);

    //}
    //void Active()
    //{
    //    if (collider == null)
    //    {
    //        collider = GetComponent<CapsuleCollider>();
    //    }

    //    if (collider != null)
    //        collider.enabled = true;


    //    if (charactercontroller == null)
    //    {
    //        charactercontroller = GetComponent<CharacterController>();
    //    }

    //    if (charactercontroller != null)
    //        charactercontroller.enabled = true;

    //    _IKHuman.IKActive = true;

    //    //_WeaponManager.enabled = true;

    //    //_WeaponManager.ResetWeaponManagerMaster();

    //    animator.SetBool("Die", false);

    //    health = healthMax;
    //    // UpdateHealthBarClone();
    //    UpdateHealthBarLocal();

    //    Transform t = SandController.instance.SpawnerPlayer();

    //    this.transform.position = t.position;
    //    this.transform.rotation = t.rotation;

    //    if (PV != null)
    //        PV.RPC("RPC_Active", RpcTarget.All, t.position, t.rotation);


    //}

    public override void Damage(int damage)
    {


        if (IsDead) return;

        if (PV != null && !PV.IsMine)
        {
            base.Damage(damage);
            PV.RPC("RPC_ApplyDamage", RpcTarget.All, damage);

            UpdateHealthBarClone();

            //if (IsDead)
            //{
            //    Die();
            //    return;
            //}


        }


    }

    #region RPC

    [PunRPC]
    void RPC_ApplyDamage(int _health)
    {
        health = _health;

        UpdateHealthBarLocal();
    }
    #endregion

}
