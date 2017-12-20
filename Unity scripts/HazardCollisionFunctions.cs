using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HazardCollisionFunctions : MonoBehaviour {

    #region Variables
    //Public

    //Private
    #endregion

    #region UnityFunctions
    void Start()
    {
        
    }
    void Update()
    {
        
    }
    #endregion

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "platform")  //Uitvoeren wanneer het platform geraakt word door de hazard
        {
            this.gameObject.SetActive(false);       //Object wat platform raakt word gedeactiveerd (verdwijnt)
        }

        if(collision.gameObject.tag == "Player")    //Uitvoeren wanneer de speler geraakt word door de hazard
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);  //Restart van Scene (scene 1 start scene word opgestart/opnieuw afgespeeld)
        }
    }
}
