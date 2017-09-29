using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.AttributeUsage(System.AttributeTargets.Field)]
public class PotionSelectorAttribute :PropertyAttribute
{
}

public class TestBehaviour : MonoBehaviour
{

    [PotionSelector]
    public string potionName;
    public void Start()
    {
        for (int i = 0; i < PotionDB.Instance.potions.Length; i++)
        {
            if (PotionDB.Instance.potions[i].name == potionName)
            {
                Debug.Log(PotionDB.Instance.potions[i].heal);

            }

            // PotionDB.Instance pra acessar o "banco de dados" de pocoes
            // Imprimir o quanto aquela potion recupera
        }
    }
}