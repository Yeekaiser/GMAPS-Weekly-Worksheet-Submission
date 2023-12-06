using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Profiling.Memory.Experimental;
using UnityEngine;

public class HMatrix2D
{
    public float[,] Entries { get; set; } = new float[3, 3];

    public HMatrix2D()
    {
        Entries = new float[3, 3];
    }

    public HMatrix2D(float[,] multiArray)
    {
        for (int y = 0; y < multiArray.GetLength(0); y++)
            for (int x = 0; x < multiArray.GetLength(1); x++)
            {
                Entries = multiArray;

            }
    }

    public HMatrix2D(float m00, float m01, float m02,
             float m10, float m11, float m12,
             float m20, float m21, float m22)
    {
        // First row
        m00 = Entries[0, 0];
        m01 = Entries[0, 1];
        m01 = Entries[0, 1];

        // Second row
        m10 = Entries[1, 0];
        m11 = Entries[1, 1];
        m12 = Entries[1, 2];

        // Third row
        m20 = Entries[2, 0];
        m21 = Entries[2, 1];
        m22 = Entries[2, 2];
    }

    public static HMatrix2D operator +(HMatrix2D left, HMatrix2D right)
    {
        for (int y = 0; y < 3; y++) //for each row
            for (int x = 0; x < 3; x++) //for each column
                left.Entries[y, x] += right.Entries[y, x];  //add the values of the respective element from the left and right matrices together and assign it to the left matrix
        return left;
    }

    public static HMatrix2D operator -(HMatrix2D left, HMatrix2D right)
    {
        for (int y = 0; y < 3; y++) //for each row
            for (int x = 0; x < 3; x++) //for each column
                left.Entries[y, x] -= right.Entries[y, x];   //subtract the value of the right matrix from the respective element of left matrix and assign it to the left matrix
        return left;
    }

    public static HMatrix2D operator *(HMatrix2D left, float scalar)
    {
        for (int y = 0; y < 3; y++) //for each row
            for (int x = 0; x < 3; x++) //for each column
                left.Entries[y, x] *= scalar;   //multiply each element of the left matrix by the scalar value
        return left;
    }

    //// Note that the second argument is a HVector2D object
    ////
    //public static HVector2D operator *(HMatrix2D left, HVector2D right)
    //{
    //    return // your code here
    //}

    //// Note that the second argument is a HMatrix2D object
    ////
    //public static HMatrix2D operator *(HMatrix2D left, HMatrix2D right)
    //{
    //    return new HMatrix2D
    //    (
    //        /* 
    //            00 01 02    00 xx xx
    //            xx xx xx    10 xx xx
    //            xx xx xx    20 xx xx
    //            */
    //        left.Entries[0, 0] * right.Entries[0, 0] + left.Entries[0, 1] * right.Entries[1, 0] + left.Entries[0, 2] * right.Entries[2, 0],

    //        /* 
    //            00 01 02    xx 01 xx
    //            xx xx xx    xx 11 xx
    //            xx xx xx    xx 21 xx
    //            */
    //        left.Entries[0, 0] * right.Entries[0, 1] + left.Entries[0, 1] * right.Entries[1, 1] + left.Entries[0, 2] * right.Entries[2, 1],

    //    // and so on for another 7 Entries
    //);
    //}

    public static bool operator ==(HMatrix2D left, HMatrix2D right)
    {
        for(int y = 0; y < 3; y++)
            for(int x = 0; x < 3; x++)
                if (left.Entries[y, x] != right.Entries[y,x])
                    return false;
        return true;
    }

    public static bool operator !=(HMatrix2D left, HMatrix2D right)
    {
        for (int y = 0; y < 3; y++)
            for (int x = 0; x < 3; x++)
                if (left.Entries[y, x] == right.Entries[y, x])
                    return true;
        return false;
    }

    //public HMatrix2D transpose()
    //{
    //    return // your code here
    //}

    //public float GetDeterminant()
    //{
    //    return // your code here
    //}

    public void SetIdentity()   //sets the values in the matrix to be an identity matrix
    {
        //used ternary operator to keep code clean and short
        for (int y = 0; y < 3; y++)     //for each row
            for (int x = 0; x < 3; x++) //for each column
                Entries[y,x] = (x == y) ? 1 : 0;    //sets the value to 1 if the column and row number is the same, and sets to 0 for the rest
                
        //original code using if/else statements
        //for(int y = 0; y < 3;  y++ )  //for each row
        //{
        //    for(int x = 0; x < 3; x++)    //for each column
        //    {
                  //sets the value to 1 if the column and row number is the same, and sets to 0 for the rest
        //        if(x == y)    
        //        {
        //            Entries[y, x] = 1;
        //        }
        //        else
        //        {
        //            Entries[y, x] = 0;
        //        }
        //    }
        //}
    }

    public void SetTranslationMat(float transX, float transY)
    {
        // your code here
    }

    public void SetRotationMat(float rotDeg)
    {
        // your code here
    }

    public void SetScalingMat(float scaleX, float scaleY)
    {
        // your code here
    }

    public void Print()
    {
        string result = "";
        for (int r = 0; r < 3; r++)
        {
            for (int c = 0; c < 3; c++)
            {
                result += Entries[r, c] + "  ";
            }
            result += "\n";
        }
        Debug.Log(result);
    }
}
