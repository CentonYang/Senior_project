using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InputDisplay : MonoBehaviour
{
    public TMP_Text moveText, actionText;
    public PlayerController player1;
    char[] mChar = { ' ', ' ' }, aChar = { ' ', ' ' };
    string moveInput;

    void Awake()
    {
        player1 = GameObject.Find("Player1").GetComponent<PlayerController>();
    }
    void Start()
    {

    }

    void Update()
    {
        if (player1.moveKey != mChar[0])
        {
            mChar[0] = player1.moveKey;
            mChar[1] = mChar[0] == '1' ? '��' :
            mChar[0] == '2' ? '��' :
            mChar[0] == '3' ? '��' :
            mChar[0] == '4' ? '��' :
            mChar[0] == '6' ? '��' :
            mChar[0] == '7' ? '��' :
            mChar[0] == '8' ? '��' :
            mChar[0] == '9' ? '��' : '��';
            moveInput = mChar[1].ToString() + moveInput;
        }
        if (player1.actionKey != aChar[0] && player1.actionKey != ' ')
        {
            aChar[0] = player1.actionKey;
            aChar[1] = aChar[0] == 'c' ? '��' :
            aChar[0] == 'w' ? '�@' :
            aChar[0] == 's' ? '��' :
            aChar[0] == 'A' ? '��' :
            aChar[0] == 'C' ? '��' :
            aChar[0] == 'W' ? '��' :
            aChar[0] == 'S' ? '��' : '��';
            moveInput = aChar[1].ToString() + moveInput;
        }
        if (moveInput.Length > 20)
            moveInput = moveInput.Remove(moveInput.Length - 1, 1);
        moveText.text = moveInput;
    }
}


