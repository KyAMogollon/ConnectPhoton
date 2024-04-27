using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDeSkin : MonoBehaviour
{
    [SerializeField] GameObject[] listaDeSkins = new GameObject[1];
    int index;


    public void CambiarSkinD()
    {
        listaDeSkins[index].SetActive(false);
        index++;
        if (index >= listaDeSkins.Length)
        {
            index = 0;

        }
        listaDeSkins[index].SetActive(true);
    }
    public void CambiarSkinI()
    {
        listaDeSkins[index].SetActive(false);
        index--;
        if (index < 0)
        {
            index = listaDeSkins.Length-1;
        }
        listaDeSkins[index].SetActive(true);
    }

}
