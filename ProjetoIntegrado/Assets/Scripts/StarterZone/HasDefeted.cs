using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HasDefeted : MonoBehaviour
{
    [SerializeField] public string id;

    [ContextMenu("Gerar o id")]
    private void GenerateGuid()
    {
        id = System.Guid.NewGuid().ToString();
    }

    void Start()
    {
        // Checa se o inimigo já foi derrotado
        if (PlayerPrefs.GetInt(id, 0) == 1)
        {
            Destroy(gameObject);
        }
    }
}
