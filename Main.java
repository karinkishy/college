import java.net.URI;
import java.util.Arrays;
import java.util.LinkedHashSet;
import java.util.Scanner;
import java.util.Set;
import java.util.regex.Pattern;

public class Main {
    public static void main(String[] args) {
        // 1
        String s1 = "";
        System.out.println("Длина: " + s1.length());
        if (s1.isEmpty()) {
            System.out.println("Строка пустая");
        } else {
            System.out.println(s1.charAt(0));
            System.out.println(s1.charAt(s1.length() - 1));
        }

        // 2
        String s2 = "Java String";
        System.out.println(s2.toUpperCase());
        System.out.println(s2.toLowerCase());

        // 3
        String s3 = "  Пример строки  ";
        System.out.println(s3.trim());

        // 4
        String s4 = "Hello, Java!";
        System.out.println(s4.startsWith("Hello"));
        System.out.println(s4.endsWith("Java!"));

        // 5
        String s5 = "banana";
        System.out.println(s5.replace('a', 'o'));

        // 6
        String s6 = "banana";
        char target6 = 'a';
        int count6 = 0;
        for (int i = 0; i < s6.length(); i++) {
            if (s6.charAt(i) == target6) count6++;
        }
        System.out.println(count6);

        // 7
        String s7 = "one two one";
        String target7 = "one";
        System.out.println(s7.indexOf(target7));
        System.out.println(s7.lastIndexOf(target7));

        // 8
        String s8 = "Изучаем Java";
        System.out.println(s8.toLowerCase().contains("java".toLowerCase()));

        // 9
        System.out.println("Java".equalsIgnoreCase("JAVA"));

        // 10
        String s10 = "  Java   —   язык   программирования  ";
        System.out.println(s10.trim().replaceAll("\\s+", " "));

        // 11
        String s11 = "Java";
        StringBuilder reversed11 = new StringBuilder();
        for (int i = s11.length() - 1; i >= 0; i--) {
            reversed11.append(s11.charAt(i));
        }
        System.out.println(reversed11);

        // 12
        String s12 = "А роза упала на лапу Азора";
        String normalized12 = s12.replaceAll("\\s+", "").toLowerCase();
        boolean palindrome12 = true;
        for (int i = 0; i < normalized12.length() / 2; i++) {
            if (normalized12.charAt(i) != normalized12.charAt(normalized12.length() - 1 - i)) {
                palindrome12 = false;
                break;
            }
        }
        System.out.println(palindrome12);

        // 13
        String s13 = "Программирование";
        int n13 = 5;
        if (n13 >= 0 && n13 <= s13.length()) {
            System.out.println(s13.substring(0, n13));
        } else {
            System.out.println("Недопустимое значение N");
        }

        // 14
        String s14 = "Программирование";
        int start14 = 2;
        int end14 = 7;
        if (start14 >= 0 && start14 <= end14 && end14 <= s14.length()) {
            System.out.println(s14.substring(start14, end14));
        } else {
            System.out.println("Недопустимые индексы");
        }

        // 15
        String s15 = "Java String";
        System.out.println(s15.replace(" ", ""));

        // 16
        String s16 = "Java 2025";
        System.out.println(s16.replaceAll("\\d", ""));

        // 17
        String s17 = "Java 2025: язык №1!";
        System.out.println(s17.replaceAll("[^\\p{L}\\s]", ""));

        // 18
        String s18 = "Java   —  язык    программирования";
        StringBuilder result18 = new StringBuilder();
        boolean previousSpace18 = false;
        for (int i = 0; i < s18.length(); i++) {
            char c = s18.charAt(i);
            if (c == ' ') {
                if (!previousSpace18) result18.append(c);
                previousSpace18 = true;
            } else {
                result18.append(c);
                previousSpace18 = false;
            }
        }
        System.out.println(result18);

        // 19
        String s19 = "banana";
        char target19 = 'a';
        for (int i = 0; i < s19.length(); i++) {
            if (s19.charAt(i) == target19) System.out.println(i);
        }

        // 20
        String s20 = "abcde";
        int middle20 = s20.length() / 2;
        System.out.println(s20.substring(0, middle20));
        System.out.println(s20.substring(middle20));

        // 21
        String s21 = "  Java   — язык программирования  ";
        String trimmed21 = s21.trim();
        int count21 = trimmed21.isEmpty() ? 0 : trimmed21.split("\\s+").length;
        System.out.println(count21);

        // 22
        String s22 = "Java пишет чистый код";
        String[] words22 = s22.trim().split("\\s+");
        String longest22 = "";
        for (String word : words22) {
            if (word.length() > longest22.length()) longest22 = word;
        }
        System.out.println(longest22);

        // 23
        String s23 = "Java   пишет код";
        String shortest23 = null;
        for (String word : s23.trim().split("\\s+")) {
            if (!word.isEmpty() && (shortest23 == null || word.length() < shortest23.length())) {
                shortest23 = word;
            }
        }
        System.out.println(shortest23 == null ? "Слов нет" : shortest23);

        // 24
        String s24 = "изучаем JAVA";
        StringBuilder result24 = new StringBuilder();
        for (String word : s24.trim().split("\\s+")) {
            if (result24.length() > 0) result24.append(' ');
            result24.append(word.substring(0, 1).toUpperCase())
                    .append(word.substring(1).toLowerCase());
        }
        System.out.println(result24);

        // 25
        String s25 = "Java JavaScript Kotlin";
        char letter25 = 'j';
        int count25 = 0;
        for (String word : s25.trim().split("\\s+")) {
            if (!word.isEmpty() && Character.toLowerCase(word.charAt(0)) == Character.toLowerCase(letter25)) {
                count25++;
            }
        }
        System.out.println(count25);

        // 26
        String s26 = "Привет! Как дела? Всё хорошо.";
        int count26 = 0;
        for (int i = 0; i < s26.length(); i++) {
            char c = s26.charAt(i);
            if (c == '.' || c == '!' || c == '?') count26++;
        }
        System.out.println(count26);

        // 27
        String s27 = "Java изучать интересно";
        String[] words27 = s27.trim().split("\\s+");
        for (int i = words27.length - 1; i >= 0; i--) {
            System.out.print(words27[i] + (i > 0 ? " " : ""));
        }
        System.out.println();

        // 28
        String s28 = "кот пёс кот кот пёс";
        String[] words28 = s28.toLowerCase().trim().split("\\s+");
        String mostFrequent28 = "";
        int maxCount28 = 0;
        for (int i = 0; i < words28.length; i++) {
            int count = 0;
            for (String word : words28) {
                if (word.equals(words28[i])) count++;
            }
            if (count > maxCount28) {
                maxCount28 = count;
                mostFrequent28 = words28[i];
            }
        }
        System.out.println(mostFrequent28);

        // 29
        String s29 = "Java любит java";
        String[] words29 = s29.toLowerCase().trim().split("\\s+");
        boolean unique29 = true;
        for (int i = 0; i < words29.length; i++) {
            for (int j = i + 1; j < words29.length; j++) {
                if (words29[i].equals(words29[j])) unique29 = false;
            }
        }
        System.out.println(unique29);

        // 30
        String s30 = "Длинный пример текста";
        int n30 = 10;
        if (n30 < 0) {
            System.out.println("Недопустимое значение N");
        } else if (s30.length() <= n30) {
            System.out.println(s30);
        } else if (n30 <= 3) {
            System.out.println(".".repeat(n30));
        } else {
            System.out.println(s30.substring(0, n30 - 3) + "...");
        }

        // 31
        char[] a31 = "А роза".replaceAll("\\s+", "").toLowerCase().toCharArray();
        char[] b31 = "Роза а".replaceAll("\\s+", "").toLowerCase().toCharArray();
        Arrays.sort(a31);
        Arrays.sort(b31);
        System.out.println(Arrays.equals(a31, b31));

        // 32
        String first32 = "programming";
        String second32 = "program";
        int i32 = 0;
        while (i32 < first32.length() && i32 < second32.length()
                && first32.charAt(i32) == second32.charAt(i32)) {
            i32++;
        }
        System.out.println(first32.substring(0, i32));

        // 33
        String first33 = "абвгде";
        String second33 = "збвгж";
        int bestLength33 = 0;
        int bestStart33 = 0;
        for (int i = 0; i < first33.length(); i++) {
            for (int j = i + 1; j <= first33.length(); j++) {
                String part = first33.substring(i, j);
                if (part.length() > bestLength33 && second33.contains(part)) {
                    bestLength33 = part.length();
                    bestStart33 = i;
                }
            }
        }
        System.out.println(first33.substring(bestStart33, bestStart33 + bestLength33));

        // 34
        String s34 = "aaaaa";
        String target34 = "aa";
        int count34 = 0;
        if (!target34.isEmpty()) {
            int index = 0;
            while ((index = s34.indexOf(target34, index)) != -1) {
                count34++;
                index += target34.length();
            }
        }
        System.out.println(count34);

        // 35
        String s35 = "кот кот кот";
        String target35 = "кот";
        String replacement35 = "пёс";
        int index35 = s35.indexOf(target35);
        System.out.println(index35 == -1 ? s35
                : s35.substring(0, index35) + replacement35 + s35.substring(index35 + target35.length()));

        // 36
        String s36 = "кот и кот";
        String target36 = "кот";
        System.out.println(target36.isEmpty() ? s36 : s36.replace(target36, ""));

        // 37
        String first37 = "2.10";
        String second37 = "2.9";
        String[] a37 = first37.split("\\.");
        String[] b37 = second37.split("\\.");
        int length37 = Math.max(a37.length, b37.length);
        int comparison37 = 0;
        for (int i = 0; i < length37; i++) {
            int x = i < a37.length ? Integer.parseInt(a37[i]) : 0;
            int y = i < b37.length ? Integer.parseInt(b37[i]) : 0;
            if (x != y) {
                comparison37 = Integer.compare(x, y);
                break;
            }
        }
        System.out.println(comparison37);

        // 38
        String[] names38 = {"Ольга", "анна", "Борис"};
        Arrays.sort(names38, String.CASE_INSENSITIVE_ORDER);
        System.out.println(Arrays.toString(names38));

        // 39
        String s39 = "Java JavaScript изучаем Java";
        String target39 = "java";
        Set<String> found39 = new LinkedHashSet<>();
        for (String word : s39.trim().split("\\s+")) {
            if (word.toLowerCase().contains(target39.toLowerCase())) found39.add(word);
        }
        System.out.println(found39);

        // 40
        String first40 = "котик";
        String second40 = "котк";
        boolean possible40 = false;
        if (first40.length() == second40.length() + 1) {
            int i = 0;
            int j = 0;
            boolean skipped = false;
            while (i < first40.length() && j < second40.length()) {
                if (first40.charAt(i) == second40.charAt(j)) {
                    i++;
                    j++;
                } else if (!skipped) {
                    skipped = true;
                    i++;
                } else {
                    break;
                }
            }
            possible40 = true;
        }
        System.out.println(possible40);

        // 41
        String email41 = "student@example.com";
        int at41 = email41.indexOf('@');
        boolean valid41 = at41 > 0
                && at41 == email41.lastIndexOf('@')
                && at41 < email41.length() - 1
                && email41.indexOf('.', at41) > at41 + 1
                && email41.indexOf('.', at41) < email41.length() - 1;
        System.out.println(valid41);

        // 42
        String phone42 = "+7 999-123-45-67";
        String normalized42 = phone42.replace(" ", "").replace("-", "");
        System.out.println(normalized42.matches("\\+7\\d{10}"));

        // 43
        String password43 = "JavaPass1";
        boolean valid43 = password43.length() >= 8
                && password43.matches("(?s).*\\p{Lu}.*")
                && password43.matches("(?s).*\\p{Ll}.*")
                && password43.matches("(?s).*\\d.*");
        System.out.println(valid43);

        // 44
        String fullName44 = "Иван Петров";
        String[] parts44 = fullName44.trim().split("\\s+");
        if (parts44.length >= 2) {
            System.out.println(parts44[1] + ", " + parts44[0].charAt(0) + ".");
        } else {
            System.out.println("Некорректное имя");
        }

        // 45
        String number45 = "1234567";
        StringBuilder result45 = new StringBuilder();
        for (int i = 0; i < number45.length(); i++) {
            if (i > 0 && (number45.length() - i) % 3 == 0) result45.append(' ');
            result45.append(number45.charAt(i));
        }
        System.out.println(result45);

        // 46
        String s46 = "123456";
        boolean digitsOnly46 = !s46.isEmpty();
        for (int i = 0; i < s46.length(); i++) {
            if (!Character.isDigit(s46.charAt(i))) digitsOnly46 = false;
        }
        System.out.println(digitsOnly46);

        // 47
        String date47 = "19-10-2026";
        if (date47.matches("\\d{2}-\\d{2}-\\d{4}")) {
            String[] parts47 = date47.split("-");
            int day47 = Integer.parseInt(parts47[0]);
            int month47 = Integer.parseInt(parts47[1]);
            if (day47 >= 1 && day47 <= 31 && month47 >= 1 && month47 <= 12) {
                System.out.println(parts47[2] + "/" + parts47[1] + "/" + parts47[0]);
            } else {
                System.out.println("Некорректная дата");
            }
        } else {
            System.out.println("Некорректный формат");
        }

        // 48
        String username48 = "  anna   peterson  ";
        System.out.println(username48.trim().replaceAll("\\s+", " "));

        // 49
        String identifier49 = "user_1";
        boolean valid49 = !identifier49.isEmpty()
                && (Character.isLetter(identifier49.charAt(0))
                || identifier49.charAt(0) == '_'
                || identifier49.charAt(0) == '$');
        for (int i = 1; i < identifier49.length(); i++) {
            char c = identifier49.charAt(i);
            if (!Character.isLetterOrDigit(c) && c != '_' && c != '$') valid49 = false;
        }
        System.out.println(valid49);

        // 50
        String url50 = "https://www.example.com/path";
        try {
            String host50 = URI.create(url50).getHost();
            if (host50 == null) {
                System.out.println("Некорректный URL");
            } else {
                System.out.println(host50.startsWith("www.") ? host50.substring(4) : host50);
            }
        } catch (IllegalArgumentException e) {
            System.out.println("Некорректный URL");
        }

        // 51
        String text51 = "Java 2026!";
        int characters51 = text51.length();
        int letters51 = 0;
        int digits51 = 0;
        int spaces51 = 0;
        int punctuation51 = 0;
        for (int i = 0; i < text51.length(); i++) {
            char c = text51.charAt(i);
            if (Character.isLetter(c)) letters51++;
            else if (Character.isDigit(c)) digits51++;
            else if (Character.isWhitespace(c)) spaces51++;
            else punctuation51++;
        }
        System.out.println("Символы: " + characters51);
        System.out.println("Буквы: " + letters51);
        System.out.println("Цифры: " + digits51);
        System.out.println("Пробелы: " + spaces51);
        System.out.println("Знаки пунктуации: " + punctuation51);

        // 52
        String text52 = "Hello, Java!";
        int shift52 = 3;
        StringBuilder result52 = new StringBuilder();
        for (int i = 0; i < text52.length(); i++) {
            char c = text52.charAt(i);
            if (c >= 'a' && c <= 'z') {
                result52.append((char) ('a' + (c - 'a' + shift52 % 26 + 26) % 26));
            } else if (c >= 'A' && c <= 'Z') {
                result52.append((char) ('A' + (c - 'A' + shift52 % 26 + 26) % 26));
            } else {
                result52.append(c);
            }
        }
        System.out.println(result52);

        // 53
        String text53 = "Khoor, Mdyd!";
        int shift53 = 3;
        StringBuilder result53 = new StringBuilder();
        for (int i = 0; i < text53.length(); i++) {
            char c = text53.charAt(i);
            if (c >= 'a' && c <= 'z') {
                result53.append((char) ('a' + (c - 'a' - shift53 % 26 + 26) % 26));
            } else if (c >= 'A' && c <= 'Z') {
                result53.append((char) ('A' + (c - 'A' - shift53 % 26 + 26) % 26));
            } else {
                result53.append(c);
            }
        }
        System.out.println(result53);

        // 54
        String text54 = "Это плохое слово";
        String[] forbidden54 = {"плохое", "запрещено"};
        for (String word : forbidden54) {
            text54 = text54.replaceAll("(?iu)" + Pattern.quote(word), "*".repeat(word.length()));
        }
        System.out.println(text54);

        // 55
        String first55 = "Java любит строки";
        String second55 = "Java любит массивы";
        Set<String> wordsFirst55 = new LinkedHashSet<>(Arrays.asList(first55.toLowerCase().split("\\s+")));
        Set<String> wordsSecond55 = new LinkedHashSet<>(Arrays.asList(second55.toLowerCase().split("\\s+")));
        Set<String> onlyFirst55 = new LinkedHashSet<>(wordsFirst55);
        onlyFirst55.removeAll(wordsSecond55);
        Set<String> onlySecond55 = new LinkedHashSet<>(wordsSecond55);
        onlySecond55.removeAll(wordsFirst55);
        System.out.println(onlyFirst55);
        System.out.println(onlySecond55);

        // 56
        String s56 = "((a + b) * (c))";
        int balance56 = 0;
        boolean valid56 = true;
        for (int i = 0; i < s56.length(); i++) {
            if (s56.charAt(i) == '(') balance56++;
            else if (s56.charAt(i) == ')') {
                balance56--;
                if (balance56 < 0) valid56 = false;
            }
        }
        System.out.println(valid56 && balance56 == 0);

        // 57
        String fullName57 = "  Иванов   Иван    Иванович  ";
        System.out.println(fullName57.trim().replaceAll("\\s+", " "));

        // 58
        String text58 = "Java полезна. Изучайте JAVA.";
        String phrase58 = "java";
        String lowerText58 = text58.toLowerCase();
        String lowerPhrase58 = phrase58.toLowerCase();
        int index58 = 0;
        while (!lowerPhrase58.isEmpty()
                && (index58 = lowerText58.indexOf(lowerPhrase58, index58)) != -1) {
            System.out.println(index58);
            index58++;
        }

        // 59
        String text59 = "Здесь находится пример текста для демонстрации вывода первых двадцати слов и многоточия";
        String trimmed59 = text59.trim();
        String[] words59 = trimmed59.isEmpty() ? new String[0] : trimmed59.split("\\s+");
        int limit59 = Math.min(20, words59.length);
        System.out.print(String.join(" ", Arrays.copyOfRange(words59, 0, limit59)));
        if (words59.length > 20) System.out.print("...");
        System.out.println();

        // 60
        textAssistant();
    }

    static void textAssistant() {
        Scanner scanner = new Scanner(System.in);
        while (true) {
            System.out.println("1 — подсчёт слов");
            System.out.println("2 — разворот");
            System.out.println("3 — поиск");
            System.out.println("4 — замена");
            System.out.println("5 — проверка палиндрома");
            System.out.println("0 — выход");

            int choice;
            try {
                choice = Integer.parseInt(scanner.nextLine());
            } catch (NumberFormatException e) {
                System.out.println("Введите номер пункта меню");
                continue;
            }

            if (choice == 0) break;

            System.out.print("Введите текст: ");
            String text = scanner.nextLine();

            switch (choice) {
                case 1:
                    System.out.println(countWords(text));
                    break;
                case 2:
                    System.out.println(reverse(text));
                    break;
                case 3:
                    System.out.print("Что найти: ");
                    System.out.println(text.toLowerCase().contains(scanner.nextLine().toLowerCase()));
                    break;
                case 4:
                    System.out.print("Что заменить: ");
                    String oldText = scanner.nextLine();
                    System.out.print("На что заменить: ");
                    String newText = scanner.nextLine();
                    System.out.println(text.replace(oldText, newText));
                    break;
                case 5:
                    System.out.println(isPalindrome(text));
                    break;
                default:
                    System.out.println("Неизвестный пункт меню");
            }
        }
        scanner.close();
    }

    static int countWords(String text) {
        String trimmed = text.trim();
        return trimmed.isEmpty() ? 0 : trimmed.split("\\s+").length;
    }

    static String reverse(String text) {
        return new StringBuilder(text).reverse().toString();
    }

    static boolean isPalindrome(String text) {
        String normalized = text.replaceAll("\\s+", "").toLowerCase();
        for (int i = 0; i < normalized.length() / 2; i++) {
            if (normalized.charAt(i) != normalized.charAt(normalized.length() - 1 - i)) {
                return false;
            }
        }
        return true;
    }
}