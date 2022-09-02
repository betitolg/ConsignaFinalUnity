using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;


[CreateAssetMenu(fileName = "New Zombie Data",menuName = "Crear Configuracion Zombie")]
public class ZombieData :ScriptableObject
{
  
    [Header("CONFIGURACION DE MOVIMIENTO")]
    [Tooltip("LA VELOCIDAD DE MOVIMIENTO ES ENTRE 1 Y 10")]
    [SerializeField]
    [Range(1f, 10f)]
    public float speed = 2f;
    
    [Header("RANGO DE ATAQUE")]
    [Tooltip("EL RANGO DE ATAQUE ES ENTRE 1 Y 10")]
    [SerializeField]
    [Range(1f, 10f)]
    public float rangeAttack = 2f;
    [SerializeField] Animator enemyAnimator;
    
    
    
    
}
