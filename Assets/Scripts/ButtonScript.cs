using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonScript : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] List<Button> btnList;
    [SerializeField] List<GameObject> dialogList;

    private int ind;

    void Start()
    {
        /*ind = -1;
        foreach (Button btn in btnList){
            ind++;
            btn.onClick.AddListener(ShowDialog);

        }*/
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShowDialog() { 
    
    }

    public void colorButton()
    {
        this.GetComponent<Image>().color = Color.green;
    }

}