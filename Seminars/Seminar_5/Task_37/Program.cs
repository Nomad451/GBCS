﻿//========================================================\\          .
//                  Задача 37.                            \\          ⠄⣠⣼⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄⡀
//  Найдите произведение пар чисел в одномерном массиве.  \\          ⣾⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⣄
//  Парой счиаем первый и последний элемент, второй и     \\          ⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⣿⡆⠄
//  предпоследний и т. д. Результат запишите в новом      \\          ⣿⣿⣿⣿⣿⣿⣿⣿⠿⠋⠉⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⣷⠄
//  массиве.                                              \\          ⣿⣿⣿⣿⣿⣿⡟⠃⠄⠄⠄⠄⠘⣿⣿⣿⣿⣿⣿⣿⣿⣿⡆
//                                                        \\          ⣿⣿⣿⣿⣿⠋⠄⠄⠄⠄⠄⠄⠄⢿⣿⣿⣿⣿⣿⣿⣿⣿⡇
//  Пример:                                               \\          ⣿⡏⠈⠉⡯⣄⣀⣉⣉⡉⠉⠄⠄⢸⡷⣿⣿⣿⣿⣿⣿⡿⠁
//      [1, 2, 3, 4, 5] -> 5, 8, 3                        \\          ⣿⣧⠠⠄⠁⠹⣿⣿⣛⠿⠂⠄⠄⠸⣷⣿⣿⣿⣿⣿⣿⠁
//      [6, 7, 3, 6]    -> 36, 21                         \\          ⣿⣿⡲⡄⠄⠄⠄⠈⠄⠄⠄⠄⠄⠄⠘⡟⣿⣿⣿⣿⣿
//========================================================\\          ⣿⣿⢹⡇⠄⠄⠄⠄⠄⠄⢀⣀⡀⠄⠈⠄⢿⣿⣿⣿⠁
                                                                    //⣿⣿⠄⠈⠠⡀⠄⠄⠄⠠⣀⠈⠁⠄⢀⣤⣿⣿⠏⠹⡇
int[] array1 = {3, 8, 2, 6, 5};                                     //⣿⣿⠄⠄⠄⠈⠳⣆⡀⠄⠄⢀⣤⣾⣿⣿⣿⣿⣷⣦⣁
int[] array2 = new int[(array1.Length / 2) + (array1.Length % 2)];  //⠉⠹⢶⣤⡀⠄⠄⠈⠙⢿⣿⣿⣿⣿⡿⢿⣿⣿⣿⣿⣿⠷⣦⣤⣀⡀
                                                                    //⠄⠄⠈⢿⣿⣦⡀⢀⣀⠄⠙⠻⣿⣿⣷⣦⠈⠛⣿⣿⣿⣷⣦⣌⠛⠻⢶⣤⡀
for (int i = 0; i < array2.Length; i++) {                           //⠄⠄⠄⠄⣿⣿⠄⠉⠁⠄⠄⠤⢍⢫⡿⢿⣷⡀⠈⠻⠿⣿⣿⣿⣿⣶⣀⠙⢿⣆
        array2[i] = array1[i] * array1[array1.Length - 1 - i];      //⠄⠄⠄⢰⣿⡿⠄⠄⠄⠄⠄⠄⠄⠄⠄⠈⣽⢻⠄⠄⠄⠄⠄⠈⠙⢿⣿⣷⣌⢹
        if (i == array1.Length - 1 - i) {                           //⠄⠄⠄⠄⠻⠇⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠛⢒⣶⡂⠄⠄⠄⠄⠄⠄⠹⣿⣿⣶
            array2[i] = array1[array1.Length - 1 - i];              //⠄⠄⠄⠄⠈⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⠈⢹⡲⣀⡔⠄⠄⠄⠄⠄⢻⣿⣿
         }                                                          //⠄⠄⠄⠄⠄⠄⢠⡀⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⢈⣉⠄⠄⠄⠄⠄⠄⠄⢸⣿⣿
}                                                                   //⠰⡄⠄⠄⣠⣤⣤⣧⡄⠄⠄⠄⠄⠄⠄⠄⠄⡴⣼⣿⣦⣄⠄⠄⠄⠄⠄⣾⣿⣿
                                                                    //⠄⢰⣶⣿⣿⣿⣿⣿⣇⡀⢀⣴⣶⣦⣄⡒⣽⢳⡟⠛⢿⡋⠁⠄⠄⣀⣼⣿⣿⣿
Console.Write(String.Join(", ", array2));                           //⠄⠄⠹⠿⠛⢉⣙⢿⣿⣕⣾⢹⣿⡿⢋⡞⠏⠄⠄⢀⣈⠛⠻⣿⣿⣿⣿⣿⣿⣿
                                                                    //⣸⣿⢠⡄⠿⠘⠚⠄⢞⢉⡧⠄⠄⠄⠈⣠⠴⠒⠋⡹⠋⠄⠄⢿⣿⣿⣿⣿⣿⣿
                                                                    //⠙⣿⣿⡉⡐⠴⠘⣓⠸⣄⣾⣦⠄⡾⠛⠁⠄⠄⠄⠄⠄⠄⠄⢸⣿⣿⣿⣿⣿⣿
                                                                    //⠄⠈⠁⠋⠃⣠⡄⠻⢃⣿⣿⣿⡇⠄⠄⠄⠄⠄⠄⠄⠄⠄⠄⣸⣿⣿⣿⣿⡿⠋
                                                                    //⠄⠄⠄⠄⠛⠠⣴⣾⣿⣿⣿⣿⣿⡄⠄⠄⠄⠄⠄⠄⡀⠄⢀⣿⣿⣿⣿⣇
                                                                    //⠄⠄⠄⠄⣀⣀⢿⣿⣿⣿⣿⣿⣟⣷⠄⠄⠄⠄⠄⠄⡇⠄⢸⣿⣿⣿⣿⣿⡄
                                                                    //⣀⡔⠊⡹⣿⡀⠈⢿⣿⣿⣿⣿⣿⣿⡄⠄⠄⠄⠄⠄⠆⠄⢸⣿⣿⣿⣿⣿⣇
                                                                    //⣿⣧⠄⠘⣿⢷⡶⠾⣿⣿⣿⣿⣿⣿⣿⠄⠄⠄⠄⠄⠄⠄⡞⢿⣿⣿⣿⣿⣿
                                                                    //⣿⣿⢳⠄⠘⢺⣿⣶⡝⣿⣿⣿⣿⣿⣿⡇⠄⠄⠄⠄⠄⢀⠃⠸⣿⣿⣿⣿⣿⡆
  




    

    
        
   





