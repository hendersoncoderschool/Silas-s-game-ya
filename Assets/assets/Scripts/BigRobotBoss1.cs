using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class BigRobotBoss1 : MonoBehaviour
{
    public GameObject laser;
    public Transform LeftLaser;
    public Transform RightLaser;
    public GameObject player; 
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("Attack", 1f, 2f);
        player = GameObject.Find("Player");

        
    }

    // Update is called once per frame
   void Attack()
   {
        GameObject newLaser1 = Instantiate(laser, LeftLaser.position, LeftLaser.rotation);
        newLaser1.transform.position = new Vector3(newLaser1.transform.position.x, newLaser1.transform.position.y, 1);
        newLaser1.transform.right = player.transform.position - newLaser1.transform.position;
        //newLaser1.transform.rotation = Quaternion.Euler(newLaser1.transform.localEulerAngles.x, newLaser1.transform.localEulerAngles.y, newLaser1.transform.localEulerAngles.z);
        newLaser1.GetComponent<Rigidbody2D>().AddForce(10f * newLaser1.transform.right, ForceMode2D.Impulse);
<<<<<<< Updated upstream
        Instantiate(laser, RightLaser.position, RightLaser.rotation);
=======



        GameObject newLaser2 = Instantiate(laser, RightLaser.position, RightLaser.rotation);
        newLaser2.transform.position = new Vector3(newLaser2.transform.position.x, newLaser2.transform.position.y, 1);
        newLaser2.transform.right = player.transform.position - newLaser2.transform.position;
        newLaser2.GetComponent<Rigidbody2D>().AddForce(10f * newLaser2.transform.right, ForceMode2D.Impulse);

        



        
>>>>>>> Stashed changes
   }

   
}
