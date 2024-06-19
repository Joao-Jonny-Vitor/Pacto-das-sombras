using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCoffin : MonoBehaviour, IDataPersistence
{
    private Animator animator;
    private int start;
    public void LoadData(GameData data)
    {
    }

    public void SaveData(ref GameData data)
    {
    }

    private void Awake()
    {
        animator = GetComponent<Animator>();
        start = PlayerPrefs.GetInt("firstStart");
        Debug.Log("componente caixão puxou " + start);
    }
    private void Start()
    {
        Debug.Log("componente do start do caixao" + start);
        if(start == 1)
        {
            animator.SetInteger("anim_cof", 1);
        }
        else
        {
            animator.SetInteger("anim_cof", 0);
        }
    }
}
