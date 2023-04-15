using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
    [SerializeField] Character selectedCharacter;

    [SerializeField] List<Character> characterList;

    [SerializeField] Transform atkRef;

    public Character SelectedCharacter { get => selectedCharacter; }

    public void Prepare()
    {
        selectedCharacter = null;
    }

    public void SelectCharacter (Character character )
    {
        selectedCharacter = character;
    }

    public void SetPlay(bool value)
    {
        foreach (var character in characterList )
            {
                character.Button.interactable = value;
            }
    }

    public void Update()
    {
        if (Vector3.Distance(a: selectedCharacter.transform.position, b: atkRef.position) > 0.1f)
        {
            selectedCharacter.transform.position += direction * Time.deltaTime;
        }
        else
        {
            direction = Vector3.zero;
            selectedCharacter.transform.position =+
        }
        
    }

    Vector3 direction = Vector3.zero;

    public void Attack()
    {
        direction = atkRef.position - selectedCharacter.transform.position;

    }

    public bool IsAttacking()
    {
        return true;
    }
}
