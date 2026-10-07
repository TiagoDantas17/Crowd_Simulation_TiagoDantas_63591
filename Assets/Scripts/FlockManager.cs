using UnityEngine;

public class FlockManager : MonoBehaviour
{
    public static FlockManager FM;

    public GameObject fishPrefab;
    public int numFish = 20;
    public GameObject[] allFish;
    public Vector3 swimLimits = new Vector3(5, 5, 5);
    public Vector3 goalPos;

    [Header("Fish Settings")]
    [Range(0.0f, 5.0f)]
    public float minSpeed = 1.0f;
    [Range(0.0f, 10.0f)]
    public float maxSpeed = 5.0f;
    [Range(1.0f, 10.0f)]
    public float neighbourDistance = 3.0f;
    [Range(1.0f, 5.0f)]
    public float rotationSpeed = 4.0f;

    void Awake()
    {
        FM = this;
    }

    void Start()
    {
        allFish = new GameObject[numFish];

        for (int i = 0; i < numFish; i++)
        {
            Vector3 pos = this.transform.position + new Vector3(
                Random.Range(-swimLimits.x, swimLimits.x),
                Random.Range(-swimLimits.y, swimLimits.y),
                Random.Range(-swimLimits.z, swimLimits.z)
            );

            allFish[i] = Instantiate(fishPrefab, pos, Quaternion.identity);
        }
    }

    void Update()
    {
    }
}