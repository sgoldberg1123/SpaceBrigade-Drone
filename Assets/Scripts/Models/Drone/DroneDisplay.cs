using Assets.Scripts.Models.Drone;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DroneDisplay : MonoBehaviour
{
    public ScriptableDrone scriptDrone;

    public Text DroneName;
    public Text Health;

    public Image DroneSprite;

    public Text Shield;
    public Text Inspiration;


    // Start is called before the first frame update
    void Start()
    {
        DroneName.text = scriptDrone.Name;
        Health.text = scriptDrone.Health.ToString();
        DroneSprite.sprite = scriptDrone.DroneSprite;
        Shield.text = scriptDrone.Shield.ToString();
        Inspiration.text = scriptDrone.Inspiration.ToString();

    }
}
