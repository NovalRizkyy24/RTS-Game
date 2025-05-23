using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Button buildButton1;
    public Button buildButton2;
    public Button buildButton3;
    public Button buildButton4;
    public PlacementSystem placement;

    private void Start()
    {
        buildButton1.onClick.AddListener(() => Construct(0)); // Bangunan pertama
        buildButton2.onClick.AddListener(() => Construct(1)); // Bangunan kedua
        buildButton3.onClick.AddListener(() => Construct(2)); // Bangunan kedua
        buildButton4.onClick.AddListener(() => Construct(3)); // Bangunan kedua
    }

    private void Construct(int id)
    {
        Debug.Log("clicked");
        placement.StartPlacement(id);  // Memulai penempatan dengan ID yang dipilih
    }

}
