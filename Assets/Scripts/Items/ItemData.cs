using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[CreateAssetMenu(fileName = "New Item Data",menuName = "Crear Configuracion de ITEM")]
public class ItemData : ScriptableObject
{
    [Header("CONFIGURACION DE DAÑO")]
    [Tooltip("EL DAÑO ESTÁ ENTRE 2 Y 10")]
    [SerializeField]
    [Range(2, 10)]
    private int damagePoints = 2;
    public int DamagePoints { get { return damagePoints; } }
    
    
    [Header("CONFIGURACION DE CURACIÓN")]
    [Tooltip("SE PUEDE CURAR DE 2 A 10")]
    [SerializeField]
    [Range(2, 10)]
    private int healPoints = 2;
    public int HealPoints { get { return healPoints; } }
    
    
}
