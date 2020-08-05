using Assets.Scipts;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    Pet pet;

    void Start() {
        
    }

    void Update()
    {
    }
    //Beginning
    public void MakePet() {
        pet = new Pet();
        SceneManager.LoadScene("Home");
    }

    //Footer
    public void MoveToFood() { SceneManager.LoadScene("Food"); }
    public void MoveToHome() { SceneManager.LoadScene("Home"); }
    public void MoveToPlay() { SceneManager.LoadScene("Play"); }
    public void MoveToShopping() { SceneManager.LoadScene("Shopping"); }
    public void MoveToWalk() { SceneManager.LoadScene("Walk"); }
}
