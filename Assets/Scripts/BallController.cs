using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BallController : MonoBehaviour
{
    public float mass = 1f;  
    public float initialSpeed = 500f;  
    public float speedIncrement = 100f; 
    public float maxSpeed = 1500f;  
    public float minSpeed = 100f; 
	
	[SerializeField] private Text initialValueText;
    private Rigidbody2D rb;
    private bool isBallStarted = true;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.mass = mass;
        rb.velocity = Vector2.zero; 
        isBallStarted = false;
		UpdateInitialValueText();
    }

    private void FixedUpdate()
    {
        if (isBallStarted)
        {
           
            Vector2 inertiaForce = -rb.velocity * mass;

          
            rb.AddForce(inertiaForce);
        }
    }

    public void IncreaseSpeed()
    {
        if (initialSpeed < maxSpeed)
        {
            initialSpeed += speedIncrement;
        }
		UpdateInitialValueText();
    }

    public void DecreaseSpeed()
    {
        if (initialSpeed > minSpeed)
        {
            initialSpeed -= speedIncrement;
        }
		UpdateInitialValueText();
    }

    public void StartBallMovement()
{
    if (!isBallStarted)
    {
        rb.velocity = new Vector2(-initialSpeed / 100f, 0f);
        isBallStarted = true;
    }
}

	public void RestartScene()
{
	int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
	SceneManager.LoadScene(currentSceneIndex);
}

	private void UpdateInitialValueText()
{
		if(initialValueText != null)
		{
			initialValueText.text = initialSpeed.ToString();
		}
}
	
}