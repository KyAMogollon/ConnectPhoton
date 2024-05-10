using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickInstantiate : MonoBehaviour
{
    [SerializeField] GameObject _prefab;
    [SerializeField] CharacterSelectionSO _characterSelectionSO;
    [SerializeField] GameObject character;

    void Awake()
    {
        _prefab = _characterSelectionSO.player;
        Instantiate(_prefab, Vector3.zero, Quaternion.identity,character.transform);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
