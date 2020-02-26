using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace Assets.Scripts.Models.Drone
{
    [CreateAssetMenu(fileName = "Drone", menuName = "New Drone", order = 1)]
    public class ScriptableDrone : ScriptableObject
    {
        public string Name;
        public int Health;
        public int Energy;
        public int Shield;
        // Chance to Level, 00.0%
        public float Inspiration;

        public Sprite DroneSprite;

        public void Print()
        {
            Debug.Log(Name + ": Drone is at " + Health + " HP");
        }
    }
}
