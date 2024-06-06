using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationCoffin : MonoBehaviour, IDataPersistence
{
    private Animator animator;
    private bool firstTime;
    public void LoadData(GameData data)
    {
        this.firstTime = data.FirstStart;
    }

    public void SaveData(ref GameData data)
    {
        data.FirstStart = this.firstTime;
    }

    private void Start()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("firstTime", firstTime);
    }
}
