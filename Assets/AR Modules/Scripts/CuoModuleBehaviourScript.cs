using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuoModuleBehaviourScript : MonoBehaviour {


     public GameObject liquidBefore;
     public GameObject liquidAfter;
     public GameObject hydrogen;
     public GameObject particleSystemObject;
     public GameObject particleghalianpubbles;
     public GameObject listener;
     public GameObject canvas;
     public GameObject candleParticle;

     public GameObject H2;
     
     public void Called()
     {
          listener.SetActive(true);
          Invoke("StartGhalianParticles",3);
          Invoke("StartGhalian", 10);
          
     }

     public void ExitCalled()
     {
          liquidBefore.SetActive(true);
          liquidAfter.SetActive(false);
          hydrogen.SetActive(false);
          canvas.SetActive(false);
          candleParticle.SetActive(true);
     }

     public void StartGhalian()
     {
          particleSystemObject.SetActive(true);
     }

     public void Addhydrogen()
     {
          hydrogen.SetActive(true);
          H2.SetActive(false);
          Invoke("ChemicalEvent", 6);
     }

     public void Exithydrogen()
     {
         H2.SetActive(true);
         hydrogen.SetActive(false);
     }

     public void ChemicalEvent()
     {
          listener.SetActive(false);
          liquidBefore.SetActive(false);
          liquidAfter.SetActive(true);
          particleghalianpubbles.SetActive(false);
          particleSystemObject.SetActive(false);
          candleParticle.SetActive(false);
          canvas.SetActive(true);
          Invoke("ChemicalFinish", 5);
     }

     public void ChemicalFinish()
     {
          particleSystemObject.SetActive(false);
     }
     public void StartGhalianParticles()
     {
          particleghalianpubbles.SetActive(true);
     }
}
