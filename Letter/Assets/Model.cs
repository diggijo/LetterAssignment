using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Model 
{
    internal List<Vector3> vertices = new List<Vector3>();
    internal List<Vector3Int> faces = new List<Vector3Int>();
    List<Vector2> texture_coordinates = new List<Vector2>();
    List<Vector3Int> texture_index_list = new List<Vector3Int>();
    List<Vector3> normals = new List<Vector3>();

    public Model()
    {
        addVertices();
        addFaces();
        addNormals();
    }

    private void addFaces()
    {
        //Front
        faces.Add(new Vector3Int(1, 0, 2)); texture_index_list.Add(new Vector3Int(3, 2, 5));
        faces.Add(new Vector3Int(1, 2, 5)); texture_index_list.Add(new Vector3Int(3, 5, 9));
        faces.Add(new Vector3Int(4, 3, 10)); texture_index_list.Add(new Vector3Int(7, 6, 18));
        faces.Add(new Vector3Int(4, 10, 11)); texture_index_list.Add(new Vector3Int(7, 18, 19));
        faces.Add(new Vector3Int(10, 13, 11)); texture_index_list.Add(new Vector3Int(19, 18, 22));
        faces.Add(new Vector3Int(10, 9, 12)); texture_index_list.Add(new Vector3Int(18, 21, 22));
        faces.Add(new Vector3Int(10, 12, 13)); texture_index_list.Add(new Vector3Int(18, 17, 21));
        faces.Add(new Vector3Int(9, 8, 12)); texture_index_list.Add(new Vector3Int(17, 16, 21));
        faces.Add(new Vector3Int(7, 8, 9)); texture_index_list.Add(new Vector3Int(14, 16, 17));
        faces.Add(new Vector3Int(7, 6, 8)); texture_index_list.Add(new Vector3Int(14, 13, 16));

        //Back
        faces.Add(new Vector3Int(15, 16, 14)); texture_index_list.Add(new Vector3Int(28, 27, 30));
        faces.Add(new Vector3Int(15, 19, 16)); texture_index_list.Add(new Vector3Int(28, 30, 34));
        faces.Add(new Vector3Int(18, 24, 17)); texture_index_list.Add(new Vector3Int(32, 31, 43));
        faces.Add(new Vector3Int(18, 25, 24)); texture_index_list.Add(new Vector3Int(32, 43, 44));
        faces.Add(new Vector3Int(24, 25, 27)); texture_index_list.Add(new Vector3Int(44, 43, 48));
        faces.Add(new Vector3Int(24, 27, 26)); texture_index_list.Add(new Vector3Int(45, 44, 48));
        faces.Add(new Vector3Int(24, 26, 23)); texture_index_list.Add(new Vector3Int(45, 48, 49));
        faces.Add(new Vector3Int(23, 26, 22)); texture_index_list.Add(new Vector3Int(45, 49, 46));
        faces.Add(new Vector3Int(21, 23, 22)); texture_index_list.Add(new Vector3Int(40, 45, 46));
        faces.Add(new Vector3Int(21, 22, 20)); texture_index_list.Add(new Vector3Int(40, 46, 41));

        //Left
        faces.Add(new Vector3Int(0, 14, 16)); texture_index_list.Add(new Vector3Int(29, 28, 34));
        faces.Add(new Vector3Int(0, 16, 2)); texture_index_list.Add(new Vector3Int(29, 34, 35));
        faces.Add(new Vector3Int(3, 17, 24)); texture_index_list.Add(new Vector3Int(33, 32, 44));
        faces.Add(new Vector3Int(3, 24, 10)); texture_index_list.Add(new Vector3Int(33, 44, 45));
        faces.Add(new Vector3Int(6, 20, 22)); texture_index_list.Add(new Vector3Int(42, 41, 46));
        faces.Add(new Vector3Int(6, 22, 8)); texture_index_list.Add(new Vector3Int(42, 46, 47));
        faces.Add(new Vector3Int(22, 26, 12)); texture_index_list.Add(new Vector3Int(46, 49, 51));
        faces.Add(new Vector3Int(22, 12, 8)); texture_index_list.Add(new Vector3Int(46, 51, 50));

        //Right
        faces.Add(new Vector3Int(15, 1, 5)); texture_index_list.Add(new Vector3Int(4, 3, 9));
        faces.Add(new Vector3Int(15, 5, 19)); texture_index_list.Add(new Vector3Int(4, 9, 10));
        faces.Add(new Vector3Int(18, 4, 11)); texture_index_list.Add(new Vector3Int(8, 7, 19));
        faces.Add(new Vector3Int(18, 11, 25)); texture_index_list.Add(new Vector3Int(8, 19, 20));
        faces.Add(new Vector3Int(21, 7, 9)); texture_index_list.Add(new Vector3Int(15, 14, 17));
        faces.Add(new Vector3Int(21, 9, 23)); texture_index_list.Add(new Vector3Int(15, 17, 18));
        faces.Add(new Vector3Int(11, 13, 27)); texture_index_list.Add(new Vector3Int(19, 22, 25));
        faces.Add(new Vector3Int(11, 27, 25)); texture_index_list.Add(new Vector3Int(22, 26, 25));

        //Top
        faces.Add(new Vector3Int(15, 14, 0)); texture_index_list.Add(new Vector3Int(1, 0, 2));
        faces.Add(new Vector3Int(15, 0, 1)); texture_index_list.Add(new Vector3Int(1, 2, 3));
        faces.Add(new Vector3Int(21, 20, 6)); texture_index_list.Add(new Vector3Int(12, 11, 13));
        faces.Add(new Vector3Int(21, 6, 7)); texture_index_list.Add(new Vector3Int(12, 13, 14));
        faces.Add(new Vector3Int(23, 9, 10)); texture_index_list.Add(new Vector3Int(15, 14, 17));
        faces.Add(new Vector3Int(23, 10, 24)); texture_index_list.Add(new Vector3Int(15, 17, 18));

        //Bottom
        faces.Add(new Vector3Int(8, 22, 26)); texture_index_list.Add(new Vector3Int(22, 21, 24));
        faces.Add(new Vector3Int(8, 26, 12)); texture_index_list.Add(new Vector3Int(22, 24, 25));
        faces.Add(new Vector3Int(13, 12, 26)); texture_index_list.Add(new Vector3Int(19, 22, 25));
        faces.Add(new Vector3Int(13, 26, 27)); texture_index_list.Add(new Vector3Int(22, 26, 25));
        faces.Add(new Vector3Int(13, 27, 25)); texture_index_list.Add(new Vector3Int(30, 37, 31));
        faces.Add(new Vector3Int(13, 25, 11)); texture_index_list.Add(new Vector3Int(30, 36, 37));
        faces.Add(new Vector3Int(4, 18, 19)); texture_index_list.Add(new Vector3Int(34, 32, 38));
        faces.Add(new Vector3Int(4, 19, 5)); texture_index_list.Add(new Vector3Int(34, 38, 39));
        faces.Add(new Vector3Int(3, 2, 16)); texture_index_list.Add(new Vector3Int(46, 49, 51));
        faces.Add(new Vector3Int(3, 16, 17)); texture_index_list.Add(new Vector3Int(46, 51, 50));
    }

    private void addVertices()
    {
        vertices.Add(new Vector3(-5, 5, 1)); texture_coordinates.Add(new Vector2(50, 20));
        vertices.Add(new Vector3(5, 5, 1)); texture_coordinates.Add(new Vector2(450, 20));
        vertices.Add(new Vector3(-5, 3, 1)); texture_coordinates.Add(new Vector2(50, 100));
        vertices.Add(new Vector3(-1, 3, 1)); texture_coordinates.Add(new Vector2(450, 100));
        vertices.Add(new Vector3(1, 3, 1)); texture_coordinates.Add(new Vector2(530, 100));
        vertices.Add(new Vector3(5, 3, 1)); texture_coordinates.Add(new Vector2(50, 180));
        vertices.Add(new Vector3(-5, -1, 1)); texture_coordinates.Add(new Vector2(210, 180));
        vertices.Add(new Vector3(-3, -1, 1)); texture_coordinates.Add(new Vector2(290, 180));
        vertices.Add(new Vector3(-5, -3, 1)); texture_coordinates.Add(new Vector2(370, 180));
        vertices.Add(new Vector3(-3, -3, 1)); texture_coordinates.Add(new Vector2(450, 180));
        vertices.Add(new Vector3(-1, -3, 1)); texture_coordinates.Add(new Vector2(530, 180));
        vertices.Add(new Vector3(1, -3, 1)); texture_coordinates.Add(new Vector2(50, 260));
        vertices.Add(new Vector3(-3, -5, 1)); texture_coordinates.Add(new Vector2(130, 260));
        vertices.Add(new Vector3(-1, -5, 1)); texture_coordinates.Add(new Vector2(50, 340));
        vertices.Add(new Vector3(-5, 5, -1)); texture_coordinates.Add(new Vector2(130, 340));
        vertices.Add(new Vector3(5, 5, -1)); texture_coordinates.Add(new Vector2(210, 340));
        vertices.Add(new Vector3(-5, 3, -1)); texture_coordinates.Add(new Vector2(50, 420));
        vertices.Add(new Vector3(-1, 3, -1)); texture_coordinates.Add(new Vector2(130, 420));
        vertices.Add(new Vector3(1, 3, -1)); texture_coordinates.Add(new Vector2(210, 420));
        vertices.Add(new Vector3(5, 3, -1)); texture_coordinates.Add(new Vector2(290, 420));
        vertices.Add(new Vector3(-5, -1, -1)); texture_coordinates.Add(new Vector2(370, 420));
        vertices.Add(new Vector3(-3, -1, -1)); texture_coordinates.Add(new Vector2(130, 500));
        vertices.Add(new Vector3(-5, -3, -1)); texture_coordinates.Add(new Vector2(210, 500));
        vertices.Add(new Vector3(-3, -3, -1)); texture_coordinates.Add(new Vector2(370, 500));
        vertices.Add(new Vector3(-1, -3, -1)); texture_coordinates.Add(new Vector2(130, 580));
        vertices.Add(new Vector3(1, -3, -1)); texture_coordinates.Add(new Vector2(210, 580));
        vertices.Add(new Vector3(-3, -5, -1)); texture_coordinates.Add(new Vector2(290, 580));
        vertices.Add(new Vector3(-1, -5, -1)); texture_coordinates.Add(new Vector2(450, 500));
        texture_coordinates.Add(new Vector2(850, 500));
        texture_coordinates.Add(new Vector2(930, 500));
        texture_coordinates.Add(new Vector2(450, 580));
        texture_coordinates.Add(new Vector2(610, 580));
        texture_coordinates.Add(new Vector2(690, 580));
        texture_coordinates.Add(new Vector2(770, 580));
        texture_coordinates.Add(new Vector2(850, 580));
        texture_coordinates.Add(new Vector2(930, 580));
        texture_coordinates.Add(new Vector2(450, 660));
        texture_coordinates.Add(new Vector2(610, 660));
        texture_coordinates.Add(new Vector2(690, 660));
        texture_coordinates.Add(new Vector2(850, 660));
        texture_coordinates.Add(new Vector2(770, 740));
        texture_coordinates.Add(new Vector2(850, 740));
        texture_coordinates.Add(new Vector2(930, 740));
        texture_coordinates.Add(new Vector2(610, 820));
        texture_coordinates.Add(new Vector2(690, 820));
        texture_coordinates.Add(new Vector2(770, 820));
        texture_coordinates.Add(new Vector2(850, 820));
        texture_coordinates.Add(new Vector2(930, 820));
        texture_coordinates.Add(new Vector2(690, 900));
        texture_coordinates.Add(new Vector2(770, 900));
        texture_coordinates.Add(new Vector2(930, 900));
        texture_coordinates.Add(new Vector2(850, 980));
    }
    private void addNormals()
    {
        normals.Add(new Vector3(0, 0, 1));
        normals.Add(new Vector3(0, 0 - 1));
        normals.Add(new Vector3(1, 0, 0));
        normals.Add(new Vector3(-1, 0, 0));
        normals.Add(new Vector3(0, 1, 0));
        normals.Add(new Vector3(0, -1, 0));
    }

    public GameObject CreateUnityGameObject()
    {
        Mesh mesh = new Mesh();
        GameObject newGO = new GameObject();
     
        MeshFilter mesh_filter = newGO.AddComponent<MeshFilter>();
        MeshRenderer mesh_renderer = newGO.AddComponent<MeshRenderer>();

        List<Vector3> coords = new List<Vector3>();
        List<int> dummy_indices = new List<int>();
        /*List<Vector2> text_coords = new List<Vector2>();
        List<Vector3> normalz = new List<Vector3>();*/

        for (int i = 0; i < faces.Count; i++)
        {
            //Vector3 normal_for_face = normals[i];

            //normal_for_face = new Vector3(normal_for_face.x, normal_for_face.y, -normal_for_face.z);

            coords.Add(vertices[faces[i].x]); dummy_indices.Add(i * 3); //text_coords.Add(texture_coordinates[texture_index_list[i].x]); normalz.Add(normal_for_face);

            coords.Add(vertices[faces[i].y]); dummy_indices.Add(i * 3 + 2); //text_coords.Add(texture_coordinates[texture_index_list[i].y]); normalz.Add(normal_for_face);

            coords.Add(vertices[faces[i].z]); dummy_indices.Add(i * 3 + 1); //text_coords.Add(texture_coordinates[texture_index_list[i].z]); normalz.Add(normal_for_face);
        }

        mesh.vertices = coords.ToArray();
        mesh.triangles = dummy_indices.ToArray();
        /*mesh.uv = text_coords.ToArray();
        mesh.normals = normalz.ToArray();*/
        mesh_filter.mesh = mesh;

        return newGO;
    }
}
