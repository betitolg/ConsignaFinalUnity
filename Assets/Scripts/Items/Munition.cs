using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Munition : MonoBehaviour
{
    [SerializeField] protected ItemData itemData;
    
    [SerializeField]
    [Range(2, 10)]
    private int damagePoints = 2;
    public int DamagePoints { get => damagePoints;
        set => value = itemData.DamagePoints;
    }
    
    
    
    
}
