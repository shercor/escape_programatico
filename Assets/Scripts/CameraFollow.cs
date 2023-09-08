using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class CameraFollow : MonoBehaviour
{
    public Transform target; // Referencia al objeto que seguirá la cámara
    public float smoothTime = 0.2f; // Tiempo de suavizado (ajusta según tus preferencias)
    private Vector3 velocity = Vector3.zero;
    private float initialZPosition;
    private PhotonView view;

    private bool isMine;
    private void Start()
    {
        initialZPosition = transform.position.z;
    }

    private void LateUpdate()
    {
        GameObject[] jugadores = GameObject.FindGameObjectsWithTag("Player");

            foreach(GameObject jugador in jugadores)
            {
                isMine = jugador.GetComponent<PhotonView>().IsMine;
                if (isMine){
                    target = jugador.transform;
                }
                // Haz algo con el objeto del jugador
            }
        // Obtiene la posición actual de la cámara
        Vector3 currentPosition = transform.position;

        // Calcula la posición objetivo suavizada utilizando Lerp, pero mantiene la posición en Z constante
        Vector3 targetPosition = new Vector3(target.position.x, target.position.y, initialZPosition);
        Vector3 smoothPosition = Vector3.SmoothDamp(currentPosition, targetPosition, ref velocity, smoothTime);

        // Asigna la nueva posición objetivo a la cámara
        transform.position = smoothPosition;
    }
}
