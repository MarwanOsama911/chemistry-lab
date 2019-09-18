using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chemicalInteraction : MonoBehaviour
{

    public GameObject chemicalBefore;
    public GameObject chemicalAfter;
    public GameObject particleSystemObject;
    public GameObject particleghlian;
    public GameObject candleparticle;

    public GameObject canvas;

    public GameObject listener;

    public void Called()
    {
        listener.SetActive(true);
        Invoke("startghlian", 5);
        Invoke("ChemicaleEvent", 10);
    }

    public void ExitCalled()
    {
        chemicalBefore.SetActive(true);
        chemicalAfter.SetActive(false);
        canvas.SetActive(false);
        candleparticle.SetActive(true);
    }


    public void ChemicaleEvent()
    {
        listener.SetActive(false);
        chemicalBefore.SetActive(false);
        chemicalAfter.SetActive(true);
        particleghlian.SetActive(false);
        particleSystemObject.SetActive(true);
        candleparticle.SetActive(false);
        canvas.SetActive(true);
        Invoke("ChemicaleFinish", 5);
    }

    public void ChemicaleFinish()
    {
        particleSystemObject.SetActive(false);
    }

    public void startghlian()
    {
        particleghlian.SetActive(true);
    }
}
