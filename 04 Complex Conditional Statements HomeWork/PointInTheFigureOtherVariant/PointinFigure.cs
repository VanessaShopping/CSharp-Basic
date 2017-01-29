using System;

class PointinFigure
{
    static void Main(string[] args)
    {
        // inputs
        int h_scale = int.Parse(Console.ReadLine());
        int x = int.Parse(Console.ReadLine());
        int y = int.Parse(Console.ReadLine());

        // block definition (left,bottom,right,top)
        int[,] blocks = new int[,]
        {
                {0, 0, 3, 1},
                {1, 1, 2, 4}
        };

        // apply scaling factor
        for (int i = 0; i < blocks.Rank; i++)
        {
            for (int j = 0; j < blocks.GetLength(1); j++)
            {
                blocks[i, j] *= h_scale;
            }
        }

        string result = String.Empty;
        // check each block
        for (int i = 0; i < blocks.Rank; i++)
        {
            if (x > blocks[i, 0] && x < blocks[i, 2] && y > blocks[i, 1] && y < blocks[i, 3])
            {
                result = "inside";
                break; // point was found inside a block -> break
            }
            else if (x < blocks[i, 0] || x > blocks[i, 2] || y < blocks[i, 1] || y > blocks[i, 3]) // point is outside
            {
                if (result != "border") // and is not border to previous rect
                {
                    result = "outside";
                }
            }
            else
            {
                if (result == "border")
                {
                    // common SIDE -> either border or inside -> break
                    if (x == blocks[i, 0] && y == blocks[i, 1] ||
                        x == blocks[i, 0] && y == blocks[i, 3] ||
                        x == blocks[i, 2] && y == blocks[i, 1] ||
                        x == blocks[i, 2] && y == blocks[i, 3]
                        )
                    {
                        result = "border"; // vertex -> border
                    }
                    else
                    {
                        result = "inside"; // segment -> inside
                    }
                    break;
                }
                result = "border";
            }
        }

        Console.WriteLine(result);
    }
}