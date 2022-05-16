using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class createAndJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField createInput;
    public InputField joinInput;

    //Crea una sala con el nombre que elijamos
    public void CreateRoom(){
        PhotonNetwork.CreateRoom(createInput.text);
    }
    //Se conecta a la sala que elijamos
    public void JoinRoom(){
        PhotonNetwork.JoinRoom(joinInput.text);
    }

    public override void OnJoinedRoom(){
        PhotonNetwork.LoadLevel("Juego");
    }
}
