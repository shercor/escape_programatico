using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Photon.Pun;
using System.IO;

public class Cerradura : MonoBehaviour
{
    public TextMeshProUGUI T1,T2,T3,T4, mensaje;
    public GameObject spawner;
    public GameObject cofre;

    private string nombre;
    public string num1,num2,num3,num4;
    public GameObject item;
    string[] num = new string[] {"0","1","2","3","4","5","6","7","8","8","9"};
    int i,j,k,l, len1;
    private PhotonView view;
    // Start is called before the first frame update
    void Start()
    {
        i = 0;
        j = 0;
        k = 0;
        l = 0;
        mensaje.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        view = GetComponentInParent<PhotonView>();
        len1 = num.Length;
        T1.text = num[i];
        T2.text = num[j];
        T3.text = num[k];
        T4.text = num[l];
    }

    public void up1(){
        if (i == len1 - 1){
            i = 0;
        }else{
            i = i +1;
        }
    }
    public void up2(){
        if (j == len1 - 1){
            j = 0;
        }else{
            j += 1;
        }
    }

    public void up3(){
        if (k == len1 - 1){
            k = 0;
        }else{
            k += 1;
        }
    }

    public void up4(){
        if (l == len1 - 1){
            l = 0;
        }else{
            l += 1;
        }
    }

    public void down1(){
        if (i == 0){
            i = len1 - 1;
        }else{
            i = i -1;
        }
    }
    public void down2(){
        if (j == 0){
            j = len1 - 1;
        }else{
            j = j -1;
        }
    }
    public void down3(){
        if (k == 0){
            k = len1 - 1;
        }else{
            k = k -1;
        }
    }

    public void down4(){
        if (l == 0){
            l = len1 - 1;
        }else{
            l = l -1;
        }
    }

    public void verificar(){ //Verifica que la contraseña ingresada sea correcta. Si es así, destruye el cofre en todas las sesiones e instancia un documento
        if (T1.text == num1 && T2.text == num2 && T3.text == num3 && T4.text == num4 ){
            mensaje.text = "Cofre abierto";
            mensaje.color = Color.green;
            view.RPC("DestruirObjeto", RpcTarget.All);
        } else {
            mensaje.text = "Cofre no se abre";
            mensaje.color = Color.red;
        }
    }

    [PunRPC]
    void DestruirObjeto()
    {
        if (PhotonNetwork.IsMasterClient)
            {
                nombre = item.name;
                Debug.Log(nombre);
                PhotonNetwork.Instantiate(Path.Combine("MapItems",nombre + " Online") , transform.parent.position, Quaternion.identity);
                PhotonNetwork.Destroy(cofre.gameObject);
            }
            else
            {
                view.RPC("RequestMasterClientDestroy", RpcTarget.MasterClient);
            }
    }

    [PunRPC]
    void RequestMasterClientDestroy()
    {
        if (PhotonNetwork.IsMasterClient)
        {
            nombre = item.name;
            Debug.Log(nombre);
            //"Doc Newton Online"
            PhotonNetwork.Instantiate(Path.Combine("MapItems",nombre + " Online") , transform.parent.position, Quaternion.identity);
            PhotonNetwork.Destroy(cofre.gameObject);
        }
    }

    IEnumerator DelayedDestroy()
    {
        yield return new WaitForSeconds(2f);
        PhotonNetwork.Destroy(cofre.gameObject);
    }
}
