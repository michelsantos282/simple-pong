using UnityEngine;

public class IA : MonoBehaviour
{
    [SerializeField] private Transform ball;


    // Update is called once per frame
    void Update()
    {
        Vector3 newPos = new Vector3(transform.position.x, ball.position.y, transform.position.z);
        transform.position = Vector3.MoveTowards(transform.position, newPos, 2f * Time.deltaTime);


        
    }
}
