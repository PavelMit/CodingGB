// public class firstlesson2 {
//     public static void main(String[] args) {
//         int[] arr = new int[10]; // инициализация массива
//         System.out.println(arr.length);

//         arr = new int[] {1, 2, 3, 4, 5}; // инициализация массива
//         System.out.println(arr.length);

//         System.out.println(arr[3]);
//         arr[3] = 13;
//         System.out.println(arr[3]);
//     }
// }

//Многомерные массивы

public class firstlesson2 {
    public static void main(String[] args) {
        int[][] arr = new int [3][5]; 
        for (int i = 0; i < arr.length; i++){
            for (int j = 0; j < arr[i].length; j++){
                System.out.printf("%d", arr[i][j]);
            }
            System.out.println( );
        }
    }
}
