using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum TypePath {Character1, Character2, Character3 }
[CreateAssetMenu(menuName = "SO/SaveCharacter")]
public class CharacterSelectionSO : ScriptableObject
{
    public TypePath currentType;
    public GameObject player;
    public string _NickName;

    public void GetSelectionPlayer(TypePath path, GameObject currentPlayer)
    {
        currentType = path;
        player = currentPlayer;
    }
}
