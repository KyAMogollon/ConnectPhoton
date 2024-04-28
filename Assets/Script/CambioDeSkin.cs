using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambioDeSkin : MonoBehaviour
{
    public GameObject[] listaDeSkins = new GameObject[1];
    public int index;
    public SOSkin Guardado;
    private void Start()
    {
        Guardado.Skin = listaDeSkins[index];
    }

    public void CambiarSkinD()
    {
        listaDeSkins[index].SetActive(false);
        index++;
        if (index >= listaDeSkins.Length)
        {
            index = 0;

        }
        listaDeSkins[index].SetActive(true);
        Guardado.Skin = listaDeSkins[index];
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
        Guardado.Skin = listaDeSkins[index];
    }

}
