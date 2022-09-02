using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieStalker : Zombie
{
   
    [SerializeField] Transform playerTransform;
    
    
    
    protected override void Move()
    {
         LookPlayer();
        // Con la resta vectorial obtengo la dirección que me permite desplazarme hacia el player.
        Vector3 direction = (playerTransform.position - transform.position);
        // Uso la magnitude para avanzar solo hasta cierta distancia (y no superponer el enemigo)
        if (direction.magnitude > 1f)
        {
            // Uso normalized para trasformar el vector en un vector de magnitud uno (para avanzar de forma gradual y constante cada frame)
            transform.position += direction.normalized * zombieData.speed * Time.deltaTime;
        }
       
        
    }
    
    private void LookPlayer()
    {
        // Método para rotar "inmediatamente" hacia un trasform.
        //transform.LookAt(playerTransform);
        // Forma para rotar "gradualmente" hacia un trasform.
        Quaternion newRotation = Quaternion.LookRotation(playerTransform.position - transform.position);
        transform.rotation = Quaternion.Lerp(transform.rotation, newRotation, 1.5f * Time.deltaTime);
    }

  


}
