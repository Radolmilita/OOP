package com.company;

import java.util.Arrays;
import java.util.Comparator;
import java.util.Scanner;
import java.util.stream.Stream;

public class Main {

    public static void main(String[] args) {
        Watch casio = new Watch("Casio", "Сстрелочный", 12);
        System.out.println(casio);


        SmartWatch appleWatch = new Watch();

        //В качестве локальной переменной
        appleWatch.SetSmartWatchName("Apple Watch");
        appleWatch.SetInbuiltMemory(8);
        appleWatch.SetMatrixType("OLED");
        System.out.println(appleWatch.GetSmartWatchName()
                +" " + appleWatch.GetInbuiltMemory() +" " + appleWatch.GetMatrixType());
        SmartWatch some = createSmartwatch("Samsung", "AmoLED",16, true);
        some.print();
        SmartWatch gear = new Watch();
        gear.SetInbuiltMemory(32);
        gear.SetSmartWatchName("Gear");
        gear.SetMatrixType("Amo-Led");

        SmartWatch[] watches = { some, gear, appleWatch
        };
        System.out.println("Print: 1-- for sort by name         2-- sort by matrixType          3-- sort by memory");
        Scanner selectSort = new Scanner(System.in);
        switch(selectSort.nextInt()){
            case 1:
                Arrays.sort(watches, Comparator.comparing(SmartWatch::GetSmartWatchName));;// Сортировка по name
                for (SmartWatch item:
                     watches) {
                    System.out.println(item);
                }
                break;
            case 2:
                Arrays.sort(watches, Comparator.comparing(SmartWatch::GetMatrixType)); // Сортировка по matrixType
                for (SmartWatch item:
                        watches) {
                    System.out.println(item);
                }
                break;
            case 3:
                Arrays.sort(watches, Comparator.comparing(SmartWatch::GetInbuiltMemory,Comparator.reverseOrder())); // Сортировка по inbuiltMemory
                for (SmartWatch item:
                        watches) {
                    System.out.println(item);
                }
                break;
        }
        System.out.println("Print: 1-- for filter by name         2-- filter by matrixType          3-- filter by memory");
        Scanner selectFilter = new Scanner(System.in);
        Stream<Watch> watchStream = Stream.of(new Watch("Apple watch","ss", 24), new Watch("GShock","qwe", 12),
                new Watch("Xiaomi","aa", 24), new Watch("Samsung","fd",24));

        switch (selectFilter.nextInt()){
            case 1:
                watchStream.filter(p->p.GetTimeFormat()<12).forEach(p->System.out.println(p.GetName()));
                break;
            case 2:
                watchStream.filter(p->p.GetName() == "Samsung").forEach(p->System.out.println(p.GetName()));
                break;
        }


        ElectronicalWatch casioRM = new ElectronicalWatch();
        casioRM.SetSmartWatchName("CASIO RM");
        casioRM.SetFormFactor("wearable");
        casioRM.SetDisplayType("ЖК");
        casioRM.print();
    }

    Comparator<Watch> forWatch = new Comparator<Watch>() {
        @Override
        public int compare(Watch o1, Watch o2) {
            return 0;
        }
    };

    //Возврат интерфейса в качестве возвращаемого значения
    //createSmartWatch() возвращает объект SmartWatch
    //поэтому также можно возвратить объект watch
    static SmartWatch createSmartwatch(String name, String dialType, int inbuiltMemory, boolean option) {

        if (option == false)
            return new Watch("NaN", "NaN", 0);
        else{
            return new Watch(name, dialType, inbuiltMemory);
        }
    }
}
