using UnityEngine;
using System.Collections;

public class MenuKeys : MonoBehaviour {

    [Header("indique comandos")]
    public KeyCode saida, comeco0, comeco1, comeco2;
    [Header("indique o destino")]
    public string cena;

	void Update ()
    {
        if (Input.GetKey(saida)) Application.Quit();
        if (Input.GetKey(comeco0)) Application.LoadLevel(cena);
        if (Input.GetKey(comeco1)) Application.LoadLevel(cena);
        if (Input.GetKey(comeco2)) Application.LoadLevel(cena);
    }
}
