using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ListsLoopsArgs : MonoBehaviour
{
    [SerializeField]
    private string[] names;
    [SerializeField]
    private GameObject prefab;
    [SerializeField]
    private float spacing = 1.1f;

    private List<GameObject> cubes = new List<GameObject>();

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < names.Length; i++)
        {
            Vector3 position = new Vector3(0, 0, i * spacing);
            cubes.Add(Instantiate(prefab, position, Quaternion.identity, transform));
        }

        foreach (GameObject cube in cubes)
        {
            int index = cubes.IndexOf(cube);
            TextController textController = cube.GetComponent<TextController>();
            textController.SetText(names[index]);

            MeshRenderer renderer = cube.GetComponent<MeshRenderer>();
            renderer.material.color = Color.HSVToRGB((float)index / (float)cubes.Count, 1, 1);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
