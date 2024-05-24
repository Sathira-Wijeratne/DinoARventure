using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DinoActionController : MonoBehaviour
{
    // get multiple dinosaur game objects
    public GameObject[] dinosaurs;

    // variable to store 3 dinosaur animations for 3 dinosaurs
    public string[] animations = {
        "Armature|Pachycephalasaurus_Roar",
        "RaptorArmature|Raptor_Bite1_Anim",
        "Armature|Stegasaurus_Eat"
    };

    public string[] deathAnimations = {
        "Armature|Pachycephalasaurus_HurtHigh",
        "RaptorArmature|Raptor_Hit1_Anim",
        "Armature|Stegasaurus_HurtA 0"
    };

    public string[] sleepAnimations = {
        "Armature|Pachycephalasaurus_GoToSleep 0",
        "RaptorArmature|Raptor_GoToSleep_Anim",
        "Armature|Stegasaurus_Sleep"
    };

    public string[] fightingAnimations = {
        "Armature|Pachycephalasaurus_Roar 0",
        "RaptorArmature|Raptor_Bite1_Anim 0",
        "Armature|Stegasaurus_Roar 0"
    };

    public void startAnimations()
    {
        // loop through all dinosaurs
        for (int i = 0; i < dinosaurs.Length; i++)
        {
            // get the animator component of the dinosaur
            Animator animator = dinosaurs[i].GetComponent<Animator>();

            // play the animation of the dinosaur
            animator.Play(animations[i]);

            // log the name of the dinosaur and the animation
            Debug.Log(dinosaurs[i].name + " is playing " + animations[i]);
        }
    }

    public void killDinos()
    {
        // loop through all dinosaurs and play animations
        for (int i = 0; i < dinosaurs.Length; i++)
        {
            Animator animator = dinosaurs[i].GetComponent<Animator>();
            animator.Play(deathAnimations[i]);
            Debug.Log(dinosaurs[i].name + " is playing " + deathAnimations[i]);
        }
    }

    public void sleep()
    {
        // loop through all dinosaurs and play animations
        for (int i = 0; i < dinosaurs.Length; i++)
        {
            Animator animator = dinosaurs[i].GetComponent<Animator>();
            animator.Play(sleepAnimations[i]);
            Debug.Log(dinosaurs[i].name + " is playing " + sleepAnimations[i]);
        }
    }

    public void fight()
    {
        // loop through all dinosaurs and play animations
        for (int i = 0; i < dinosaurs.Length; i++)
        {
            Animator animator = dinosaurs[i].GetComponent<Animator>();
            animator.Play(fightingAnimations[i]);
            Debug.Log(dinosaurs[i].name + " is playing " + fightingAnimations[i]);
        }
    }
}
