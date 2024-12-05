using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ShowText : MonoBehaviour
{
    public string textvalue;
    public TextMeshProUGUI textElement;
    //private HitPoints_Handler_SpaceShip getHItpoint;
    //editer
    private SpaceShip_Script getHItpoint;

    public TextMeshProUGUI yourscore;
    void Start()
    {
        //earlier getHItpoint = GetComponent<HitPoints_Handler_SpaceShip>();
        //edited
        getHItpoint = GetComponent<SpaceShip_Script>();
    }
    
    void Update()
    {
        if (textElement != null && getHItpoint != null)
        {
            textElement.text = "Hitpoints : " + getHItpoint.getHitpoints();
        }
        else if (textElement == null)
        {
            Debug.LogError("Text Element (TextMeshProUGUI) is not assigned!");
        }
        float total = AlienShip_Script.Total_AlienShip_Destroyed + Astroid_Script.Total_Astroid_Destroyed;
        yourscore.text = "Your Score: " + total;
    }
}
