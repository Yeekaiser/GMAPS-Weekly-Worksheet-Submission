// Uncomment this whole file.

using System.Collections;
using System.Collections.Generic;
using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;

public class TestMatrix : MonoBehaviour
{
    private HMatrix2D mat = new HMatrix2D();

    void Start()
    {
        mat.SetIdentity();
        //mat.Print();
        Question2();
    }

    private void Question2()
    {
        HMatrix2D mat1 = new HMatrix2D(0, 1, 2, 3, 4, 5, 6, 7, 8);
        HMatrix2D mat2 = new HMatrix2D(0, 1, 2, 3, 4, 5, 6, 7, 8);
        HVector2D vec1 = new HVector2D(1, 4);
        HMatrix2D resultMat;
        HVector2D resultVec;

        resultMat = mat1 * mat2;
        resultMat.Print();

        resultVec = mat1 * vec1;
        resultVec.Print();
    }
}
