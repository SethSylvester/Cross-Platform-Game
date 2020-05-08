using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

//The behavior for the player of the game
public class PlayerBehavior : MonoBehaviour
{
    Vector3 startPos;
    public bool following = false;
    public bool countingDown = false;
    Rigidbody rigid;
    TrailRenderer trail;

    public float timeLeft = 3.0f;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;

        rigid = GetComponent<Rigidbody>();
        trail = GetComponent<TrailRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        //While the left mouse button is held down.
        if (Input.GetMouseButton(0)) {
            //Create an empty RaycastHit
            RaycastHit hit;
            //Raycast to the mouse position
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            //If the raycast succeeds
            if (Physics.Raycast(ray, out hit))
            {
                //Create a vector3 for the mouse position at the raycasted point
                Vector3 mousePosition = hit.point;
                //Set the Y to 0 so nothing weird happens
                mousePosition.y = 0.5f;

                if (following)
                {
                    //Move to the new position
                    transform.position = mousePosition;
                }
            }
        }
        if (Input.GetMouseButtonUp(0) && following)
        {
            Release();
        }

        if (countingDown)
        {
            timeLeft -= Time.deltaTime;
            if (timeLeft <= 0)
            {
                SceneManager.LoadScene(2);
            }
        }

        if (transform.position.x > 13 && transform.position.z < -6)
        {
            following = false;
        }
    }

    private void OnMouseDown()
    {
        following = true;
    }

    public void Fling()
    {
        following = false;

        Vector3 currentPos = transform.position;
        currentPos.y += 5;
        transform.position = currentPos;
        rigid.AddForce(220, 0.0f, 40.0f);

        countingDown = true;
    }

    public void Release()
    {
        following = false;
        transform.position = startPos;
        trail.Clear();
    }

}