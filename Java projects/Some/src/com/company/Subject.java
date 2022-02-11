package com.company;

import java.util.HashMap;
import java.util.Random;
import java.util.Scanner;

public class Subject {
    public static int HOURS_PER_CREDIT = 30;
    public static final String ANSI_RED = "\u001B[31m";
    public static final String ANSI_RESET = "\u001B[0m";

    private String subjectName;
    private int credits;

    public int getLectionHours() {
        return lectionHours;
    }

    public int getPracticeHours() {
        return practiceHours;
    }

    private int lectionHours;
    private int practiceHours;

    public HashMap<Student, boolean[]> studentPresence = new HashMap<>();
    public HashMap<Student, int[]> studentsMarks = new HashMap<>();

    public Subject(Group group, String subjectName, int credits, double ratio) {
        this.subjectName = subjectName;
        this.credits = credits;
        lectionHours = (int) (credits * HOURS_PER_CREDIT *(1 - ratio));
        practiceHours = (int) (credits * HOURS_PER_CREDIT * ratio);
        for (Student st : group.studentsArrayList) {
            this.studentPresence.put(st, new boolean[(int)(lectionHours/1.5)]);
            this.studentsMarks.put(st, new int[(int)(practiceHours/1.5)]);
        }
    }

    protected void setSubjectName(String newSubjectName) {
        subjectName = newSubjectName;
    }

    public String getSubjectName() {
        return subjectName;
    }

    public void markAttendance(int id) {
        System.out.println("Enter attendance. Use + if student is present or - if not.");
        for (Student student : studentPresence.keySet()) {
            System.out.println(student.studentName + ": ");
            Scanner sc = new Scanner(System.in);
            char some = sc.next().charAt(0);

            char[] arr = {'+', '-'};
            Random r = new Random();
            int randomNumber = r.nextInt(arr.length);
            char c = arr[randomNumber];

            if (c == '+') {
                studentPresence.get(student)[id] = true;
            } else {
                studentPresence.get(student)[id] = false;
            }

        }
    }

    public void markStudents(int id) {
        System.out.println("Enter attendance. Use + if student is present or - if not.");
        for (Student student : studentPresence.keySet()) {
            System.out.println(student.studentName + ": ");
            Scanner sc = new Scanner(System.in);
            int c = sc.next().charAt(0);

            int[] arr = {1,2,3,4,5,6,7,8,9,10};
            Random r = new Random();
            int randomNumber = r.nextInt(arr.length);
            studentsMarks.get(student)[id] = arr[randomNumber];

        }
    }

    public void markStudent(Student student, int id) {
        System.out.println("Enter attendance. Use + if student is present or - if not.");
        System.out.println(student.studentName + ": ");
        Scanner sc = new Scanner(System.in);
        int c = sc.next().charAt(0);

        int[] arr = {1,2,3,4,5,6,7,8,9,10};
        Random r = new Random();
        int randomNumber = r.nextInt(arr.length);
        putMark(student, id, arr[randomNumber]);
    }

    public void putMark(Student student, int id, int mark) {
        studentsMarks.get(student)[id] = mark;
    }

    @Override
    public String toString() {
        return ANSI_RED + "Subject name : " + ANSI_RESET + subjectName +
                ANSI_RED + " Total hours " + ANSI_RESET + creditsToHours(credits) +
                ANSI_RED + " Lection hours " + ANSI_RESET + getLectionHours() +
                ANSI_RED + " Practice hours " + ANSI_RESET + getPracticeHours();
    }

    public String displayPresence() {
        StringBuilder sb = new StringBuilder();
        for (Student student : studentPresence.keySet()) {
            sb.append(student.studentName);
            for (boolean pres : studentPresence.get(student)) {
                sb.append(pres ? "+" : "-");
                sb.append(" ");
            }
            sb.append("\n");
        }
        return sb.toString();
    }

    public String displayMarks() {
        StringBuilder sb = new StringBuilder();
        for (Student student : studentPresence.keySet()) {
            sb.append(student.studentName);
            for (boolean pres : studentPresence.get(student)) {
                sb.append(pres ? "+" : "-");
                sb.append(" ");
            }
            sb.append("\n");
        }
        return sb.toString();
    }

    public String displayMarksByStudent(Student student) {
        StringBuilder sb = new StringBuilder();
        for (int mark : studentsMarks.get(student)) {
            sb.append(mark);
            sb.append(" ");
        }
        sb.append("\n");
        return sb.toString();
    }

    public String displayPresenceByStudent(Student student) {
        StringBuilder sb = new StringBuilder();
        for (boolean pres : studentPresence.get(student)) {
            sb.append(pres ? "+" : "-");
            sb.append(" ");
        }
        sb.append("\n");
        return sb.toString();
    }

    public static int creditsToHours(int credits) {
        return credits * HOURS_PER_CREDIT;
    }
}
