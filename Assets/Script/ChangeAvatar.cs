using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeAvatar : MonoBehaviour
{
    static ChangeAvatar _instance;
    static public bool isActive
    {
        get
        {
            return _instance != null;
        }
    }
    static public ChangeAvatar instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = Object.FindObjectOfType(typeof(ChangeAvatar)) as ChangeAvatar;

                if (_instance == null)
                {
                    GameObject go = new GameObject("UIManager");
                    DontDestroyOnLoad(go);
                    _instance = go.AddComponent<ChangeAvatar>();
                }
            }
            return _instance;
        }
    }
    [SerializeField] private List<CharacterComponent> ListComponents = new List<CharacterComponent>();
    [SerializeField] CharacterComponent InitComp;
    public int Index;
    public void ActivateComponent(ComponentCh Type)
    {
        foreach (var item in ListComponents)
        {
            if (item.type == Type)
            {
                item.gameObject.SetActive(true);
            }
            else
            {
                item.gameObject.SetActive(false);
            }
        }
    }
    public void Move(int index)
    {
        if (index < 0)
        {
            Index--;
           
        }
            
        else
            Index++;

        Index = Mathf.Clamp(Index, 0, ListComponents.Count - 1);
        ActivateComponent(ListComponents[Index].type);

        //Index += index;
        //if (Index == -1)
        //{
        //    Index = ListComponents.Count;
        //    ActivateComponent(ListComponents[Index].type);
        //}
        //else if(Index== ListComponents.Count)
        //{
        //    Index = 0;
        //    ActivateComponent(ListComponents[Index].type);
        //}
    }
    private void Start()
    {
        ActivateComponent(InitComp.type);
    }
}
