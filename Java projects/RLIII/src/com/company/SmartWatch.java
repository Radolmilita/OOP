package com.company;

public interface SmartWatch {
    default void print(){
        System.out.println("Undefined variable");
    }
    void SetSmartWatchName(String some);
    String GetSmartWatchName();
    void SetMatrixType(String some);
    String GetMatrixType();
    void SetInbuiltMemory(int capacity);
    int GetInbuiltMemory();

}
