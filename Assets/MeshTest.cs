using UnityEngine;
using System.Collections;

public class MeshTest : MonoBehaviour {
    public float width;
    public float height;
    public Material material;


    private Mesh mesh;
    private Vector3[] verticies;
    private Vector3[] normals;
    private Vector2[] uv;
    private int[] triangles;
    void Start() {

        if (!transform.GetComponent<MeshFilter>() || !transform.GetComponent<MeshRenderer>()) //If you will havent got any meshrenderer or filter
         {
            transform.gameObject.AddComponent<MeshFilter>();
            transform.gameObject.AddComponent<MeshRenderer>();
        }

        Mesh mesh = new Mesh();
        transform.GetComponent<MeshFilter>().mesh = mesh;
        mesh.name = "MyOwnObject";


        Vector3[] verticies = new Vector3[4];
        verticies[0] = new Vector3(0, 0, 0);
        verticies[1] = new Vector3(width, 0, 0);
        verticies[2] = new Vector3(0, height, 0);
        verticies[3] = new Vector3(width, height, 0);

        mesh.vertices = verticies;

        int[] triangles = new int[6];

        triangles[0] = 0;
        triangles[1] = 2;
        triangles[2] = 1;

        triangles[3] = 2;
        triangles[4] = 3;
        triangles[5] = 1;

        mesh.triangles = triangles;

        Vector3[] normals = new Vector3[4];

        normals[0] = -Vector3.forward;
        normals[1] = -Vector3.forward;
        normals[2] = -Vector3.forward;
        normals[3] = -Vector3.forward;

        mesh.normals = normals;

        Vector2[] uv = new Vector2[4];

        uv[0] = new Vector2(0, 0);
        uv[1] = new Vector2(1, 0);
        uv[2] = new Vector2(0, 1);
        uv[3] = new Vector2(1, 1);

        mesh.uv = uv;

        transform.gameObject.GetComponent<Renderer>().material = material;
    }
	
	// Update is called once per frame
	void Update () {
       Vector3[] verticies = new Vector3[33];
        int j = 0;
        int k = 0;
        for (int i = 0; i < 33; i++) {
            verticies[i] = new Vector3(i, j, k);
            j++;
            k++;
        }
        mesh.vertices = verticies;

        int[] triangles = new int[99];
        



	}
}
