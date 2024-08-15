using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PROJECT
{
    class Program
    {
        /// <summary>
        /// Phương thức chính cho chương trình.
        /// </summary>
        static void Main(string[] args)
        {
            // Thiết lập mã hóa console để hỗ trợ ký tự Unicode
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;

            //biến exit để thoát khỏi chương trình
            bool exit = false;

            // biến để thực hiện vòng lặp làm lại bài toán
            int luaChon;
            bool userResponse;



            while (!exit)
            {
                //cho phép người dùng trở về menu chính ngay lập tức
                BackToMenu:
                Console.Clear();

                Console.WindowWidth = 107; //Cài đặt độ rộng mặc định của cửa sổ console 

                // Hiển thị thông báo chào mừng
                Console.WriteLine("╔═══════════════════════════════════════════════════════════════════════════════════════════════════════╗");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.WriteLine("                         CHÀO MỪNG ĐẾN VỚI BÀI ĐỒ ÁN KẾT THÚC MÔN HỌC CƠ SỞ LẬP TRÌNH                      ");
                Console.ResetColor();
                Console.WriteLine("                                    NHÓM 3, LỚP: 23C1INF50900505 - CHIỀU T5                                ");
                Console.WriteLine("╚═══════════════════════════════════════════════════════════════════════════════════════════════════════╝");

                // Thiết lập màu sắc console cho menu
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;

                // Hiển thị menu chính
                Console.WriteLine("\n╔" + new string('═', 34) + "[MENU LỰA CHỌN TỪNG PHẦN CỦA ĐỒ ÁN]" + new string('═', 34) + "╗");
                Console.WriteLine("║                                1. Đoàn Thị Hồng Nhung [STT 28]                                        ║");
                Console.WriteLine("║                                2. Trần Thị Kiều Trinh [STT 39]                                        ║");
                Console.WriteLine("║                                3. Tăng Khánh Hào [STT 10] & Bùi Phương Nam [STT 20]                   ║");
                Console.WriteLine("║                                4. Cả nhóm [STT nhóm: 3]                                               ║");
                Console.WriteLine("║                                0. Thoát                                                               ║");
                Console.Write("╚" + new string('═', 103) + "╝\n");
                Console.ResetColor();

                // Nhắc người dùng chọn một phần
                Console.Write("\nChọn STT tương ứng với tên sinh viên bạn muốn xem lời giải: ");
                int part;
                while ((!int.TryParse(Console.ReadLine(), out part)) || part < 0 || part > 4)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nLỰA CHỌN KHÔNG HỢP LỆ. VUI LÒNG NHẬP LẠI!");
                    Console.ResetColor();
                    Console.Write("Chọn STT tương ứng với tên sinh viên bạn muốn xem lời giải: ");
                }
                switch (part) //switch case lựa chọn từng phần của bài đồ án
                {
                    case 1: // Thực hiện giải bài tập của Đoàn Thị Hồng Nhung [STT 28] ở đây

                        do //Vòng lặp cho phép người dùng chọn lại câu hỏi trong phần này
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;

                            //Hiển thị đề bài
                            Console.WriteLine("\n+" + new string('-', 37) + "[Đoàn Thị Hồng Nhung [STT 28]]" + new string('-', 37) + "+");
                            Console.WriteLine("|P1. Tìm bán kính hình cầu có thể tích tương đương với hình trụ tròn có bán kính R và chiều cao h.       |\n|" + new string(' ', 104) + "|");
                            Console.WriteLine("|P2. Nhập một mảng các số nguyên dương, nhập 2 số nguyên dương N, M (N<M)                                |" +
                                            "\n|      Cho biết trong mảng có bao nhiêu số thuộc đoạn [N,M], in các số này cùng vị trí của nó trong mảng |\n|" + new string(' ', 104) + "|");
                            Console.WriteLine("|P3. Nhập ma trận vuông cấp n. Tính tổng các phần tử chẵn nằm ở tam giác dưới đường chéo chính           |" +
                                            "\n|      (kể cả đường chéo chính)                                                                          |\n|" + new string(' ', 104) + "|");
                            Console.WriteLine("|0. Quay lại                                                                                             |");
                            Console.Write("+" + new string('-', 104) + "+\n");
                            Console.ResetColor();

                            Console.Write("\nĐiền số 1, 2, 3 tương ứng với số phần mà bạn muốn xem lời giải bài 8 của Đoàn Thị Hồng Nhung [STT 28] hoặc 0 để quay lại menu chính: ");
                            int part1;

                            //Ràng buộc để người dùng chỉ có thể nhập giá trị 1, 2, 3
                            while ((!int.TryParse(Console.ReadLine(), out part1)) || part1 < 0 || part1 > 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nLỰA CHỌN KHÔNG HỢP LỆ. VUI LÒNG NHẬP LẠI!");
                                Console.ResetColor();
                                Console.Write("Điền số 1, 2, 3 tương ứng với số phần mà bạn muốn xem lời giải bài 8 của Đoàn Thị Hồng Nhung [STT 28] hoặc 0 để quay lại menu chính: ");
                            }

                            switch (part1) // Xử lý lựa chọn câu muốn làm trong phần của Đoàn Thị Hồng Nhung [STT 28]
                            {
                                case 1:
                                    SolveP1Bai8();
                                    break;

                                case 2:
                                    SolveP2Bai8();
                                    break;

                                case 3:
                                    SolveP3Bai8();
                                    break;

                                case 0: // Thêm case mới để quay lại switch part ngay lập tức
                                    goto BackToMenu;

                            }
                            Console.WriteLine("\n" + new string('-', 104));

                            // Gọi phương thức static LuaChonTiepTuc để xử lý lựa chọn của người dùng có muốn tiếp tục giải bài toán khác trong phần này không
                            userResponse = LuaChonTiepTuc(out luaChon);

                        } while (userResponse);
                        break;

                    case 2: // Thực hiện giải bài tập của Trần Thị Kiều Trinh [STT 39] ở đây

                        do  //Vòng lặp cho phép người dùng chọn lại câu hỏi trong phần này
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;

                            //Hiển thị đề bài
                            Console.WriteLine("\n+" + new string('-', 37) + "[Trần Thị Kiều Trinh [STT 39]]" + new string('-', 37) + "+");
                            Console.WriteLine("|P1. Tìm bán kính hình cầu có thể tích tương đương với hình hộp chữ nhật có số đo ba chiều là a, b, c.   |\n|" + new string(' ', 104) + "|");
                            Console.WriteLine("|P2. Cho dãy các quả cân sau : 1g, 2g, 4g, 8g, 16g, 32g, 64g, 128g, 256g                                 |" +
                                            "\n|       Nhập trọng lượng M (M < 512g), cho biết các quả cân sẽ sử dụng để cân vật có trọng lượng M       |" +
                                            "\n|       (mỗi quả cân dùng tối đa 1 lần)                                                                  |\n|" + new string(' ', 104) + "|");
                            Console.WriteLine("|P3. Nhập ma trận vuông cấp n. Cho biết trong ma trận vừa nhập có 2 hàng nào trùng nhau hay không,       |" +
                                            "\n|       nếu có thì cho biết là 2 hàng nào.                                                               |\n|" + new string(' ', 104) + "|");
                            Console.WriteLine("|0. Quay lại                                                                                             |");
                            Console.Write("+" + new string('-', 104) + "+");
                            Console.ResetColor();

                            Console.Write("\nĐiền số 1, 2, 3 tương ứng với số phần mà bạn muốn xem lời giải bài 9 của Trần Thị Kiều Trinh [STT 39] hoặc 0 để quay lại menu chính: ");
                            int part2;

                            //Ràng buộc để người dùng chỉ có thể nhập giá trị 1, 2, 3
                            while ((!int.TryParse(Console.ReadLine(), out part2)) || part2 < 0 || part2 > 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nLỰA CHỌN KHÔNG HỢP LỆ. VUI LÒNG NHẬP LẠI!");
                                Console.ResetColor();
                                Console.Write("Điền số 1, 2, 3 tương ứng với số phần mà bạn muốn xem lời giải bài 9 của Trần Thị Kiều Trinh [STT 39] hoặc 0 để quay lại menu chính: ");
                            }

                            switch (part2) // Xử lý lựa chọn câu muốn làm trong phần của Trần Thị Kiều Trinh [STT 39]
                            {
                                case 1:
                                    SolveP1Bai9();
                                    break;

                                case 2:
                                    SolveP2Bai9();
                                    break;

                                case 3:
                                    SolveP3Bai9();
                                    break;

                                case 0: // Thêm case mới để quay lại switch part ngay lập tức
                                    goto BackToMenu;

                            }
                            Console.WriteLine("\n" + new string('-', 104));

                            // Gọi phương thức static LuaChonTiepTuc để xử lý lựa chọn của người dùng có muốn tiếp tục giải bài toán khác trong phần này không
                            userResponse = LuaChonTiepTuc(out luaChon);

                        } while (userResponse);
                        break;

                    case 3: // Thực hiện giải bài tập của Tăng Khánh Hào [STT 10] và Bùi Phương Nam [STT 20] ở đây
                        do
                        {
                            Console.BackgroundColor = ConsoleColor.DarkRed;

                            //Hiển thị đề bài
                            Console.WriteLine("\n+" + new string('-', 26) + "[Tăng Khánh Hào [STT 10] và Bùi Phương Nam [STT 20]]" + new string('-', 26) + "+");
                            Console.WriteLine("|P1. Một hình cầu có bán kính R và một hình trụ tròn có bán kính r và chiều cao h.                       |" +
                                            "\n|        Nếu bán kính mỗi hình đều tăng lên gấp đôi, thì thể tích sẽ thay đổi như thể nào.               |\n|" + new string(' ', 104) + "|");
                            Console.WriteLine("|P2. Nhập số hạng đầu tiên của cấp số cộng, công sai của cấp số cộng, số lượng phần tử cần in.           |" +
                                            "\n|        Sau đó in ra dãy cấp số cộng này                                                                |\n|" + new string(' ', 104) + "|");
                            Console.WriteLine("|P3. Nhập ma trận vuông cấp n. In các phần tử của ma trận này dọc theo phương của đường chéo chính.      |\n|" + new string(' ', 104) + "|");
                            Console.WriteLine("|0. Quay lại                                                                                             |");
                            Console.Write("+" + new string('-', 104) + "+");
                            Console.ResetColor();


                            Console.Write("\nĐiền số 1, 2, 3 tương ứng với số phần mà bạn muốn xem lời giải bài 10 của Tăng Khánh Hào [STT 10] & Bùi Phương Nam [STT 20] hoặc 0 để quay lại menu chính: ");
                            int part3;

                            //Ràng buộc để người dùng chỉ có thể nhập giá trị 1, 2, 3
                            while ((!int.TryParse(Console.ReadLine(), out part3)) || part3 < 0 || part3 > 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("\nLỰA CHỌN KHÔNG HỢP LỆ. VUI LÒNG NHẬP LẠI!");
                                Console.ResetColor();
                                Console.Write("Điền số 1, 2, 3 tương ứng với số phần mà bạn muốn xem lời giải bài 10 của Tăng Khánh Hào [STT 10] & Bùi Phương Nam [STT 20] hoặc 0 để quay lại menu chính: ");
                            }

                            switch (part3) // Xử lý lựa chọn câu muốn làm trong phần của Tăng Khánh Hào [STT 10] và Bùi Phương Nam [STT 20]
                            {
                                case 1:
                                    SolveP1Bai10();
                                    break;

                                case 2:
                                    SolveP2Bai10();
                                    break;

                                case 3:
                                    SolveP3Bai10();
                                    break;

                                case 0: // Thêm case mới để quay lại switch part ngay lập tức
                                    goto BackToMenu;

                                default:
                                    userResponse = LuaChonTiepTuc(out luaChon);
                                    break;
                            }
                            Console.WriteLine("\n" + new string('-', 104));

                            // Gọi phương thức static LuaChonTiepTuc để xử lý lựa chọn của người dùng có muốn tiếp tục giải bài toán khác trong phần này không
                            userResponse = LuaChonTiepTuc(out luaChon);

                        } while (userResponse);
                        break;

                    case 4: // Thực hiện giải bài tập Phần 4 ở đây
                        Console.BackgroundColor = ConsoleColor.DarkRed;

                        //Hiển thị đề bài
                        Console.WriteLine("\n+" + new string('-', 45) + "[PHẦN 4 || LẺ]" + new string('-', 45) + "+");
                        Console.WriteLine("| Cho mảng nhiều chiều gồm có các thông tin liên quan đến khách lưu trú ở khách sạn.                     |" +
                                        "\n| Khách gồm các thông tin: họ tên, số ngày ở, số bữa ăn, tiền ở(1 ngày), tiền ăn(1 bữa), phí phục vụ.    |" +
                                        "\n| Phân tích và viết chương trình tính tiền trọ khách sạn.In hóa đơn tính tiền lên màn hình.              |");
                        Console.Write("+" + new string('-', 104) + "+");
                        Console.ResetColor();

                        do
                        {
                            SolveP4Lẻ();
                            Console.WriteLine("\n" + new string('-', 104));

                            // Gọi phương thức static LuaChonTiepTuc để xử lý lựa chọn của người dùng có muốn tiếp tục giải bài toán khác trong phần này không
                            userResponse = LuaChonTiepTuc(out luaChon);

                        } while (userResponse);
                        break;

                    case 0: //Thoát khỏi đồ án

                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("CẢM ƠN THẦY ĐÃ XEM ĐỒ ÁN NÀY!\n");
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("    ****   ****  ");
                            Console.WriteLine("  ******* ******* ");
                            Console.WriteLine("  *************** ");
                            Console.WriteLine("   ************* ");
                            Console.WriteLine("    *********** ");
                            Console.WriteLine("      ******* ");
                            Console.WriteLine("        *** ");
                            Console.WriteLine("         *");
                            Thread.Sleep(500); // Dừng trong 0.5 giây
                            Console.Clear();
                            Thread.Sleep(500); // Dừng trong 0.5 giây
                            Console.ResetColor();
                        }
                }
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Phương thức cho phép người dùng lựa chọn tiếp tục giải bài toán khác trong phần hiện tại.
        /// </summary>
        /// <returns>True nếu người dùng chọn tiếp tục, False nếu người dùng không chọn tiếp tục.</returns>
        static bool LuaChonTiepTuc(out int luaChon)
        {
            do
            {
                Console.Write("Bạn có muốn tiếp tục giải bài toán không? [1 - Có || 0 - Không]: ");
            } while (!int.TryParse(Console.ReadLine(), out luaChon) || (luaChon != 0 && luaChon != 1));
            Console.Clear();
            return (luaChon == 1);
        }

        /// <summary>
        /// Phương thức để đảm bảo người dùng nhập số nguyên dương.
        /// </summary>
        /// <returns>Số nguyên dương được người dùng nhập.</returns>
        static int GetPositiveIntInput() // Phương thức để đảm bảo người dùng nhập số nguyên dương
        {
            int input;
            while (!int.TryParse(Console.ReadLine(), out input) || input <= 0)
            {
                Console.Write("\nGiá trị đầu vào sai, mời nhập lại: ");
            }
            return input;
        }

        /// <summary>
        /// Phương thức để đảm bảo người dùng nhập số thực dương.
        /// </summary>
        /// <returns>Số thực dương nhập từ người dùng.</returns>
        static double GetPositiveDoubleInput()
        {
            double input;
            while (!double.TryParse(Console.ReadLine(), out input) || input <= 0)
            {
                Console.Write("Vui lòng nhập một số dương hợp lệ: ");
            }
            return input;
        }

        /// <summary>
        /// Phương thức tạo ma trận vuông cấp n.
        /// </summary>
        /// <returns>Ma trận vuông với các phần tử được nhập từ bàn phím.</returns>
        static double[,] TaoMaTranVuong(int n)
        {
            //Khai báo mảng
            double[,] matrix = new double[(int)n, (int)n];

            // Nhập ma trận
            Console.WriteLine("\nNhập các phần tử cho ma trận vuông:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write($"Nhập phần tử [{i + 1}, {j + 1}]: ");

                    while (!double.TryParse(Console.ReadLine(), out matrix[i, j]))
                    {
                        Console.Write("\nGiá trị đầu vào sai, mời nhập lại: ");
                    }
                }
            }

            // In ra ma trận vừa nhập
            Console.WriteLine("\nMa trận vừa nhập:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
            return matrix;
        }

        /// <summary>
        /// Giải bài số 8 của phần 1: Tìm bán kính hình cầu có thể tích tương đương với hình trụ tròn có bán kính R và chiều cao h.
        /// </summary>
        static void SolveP1Bai8()
        {
            Console.WriteLine("Đây là phần do bạn Hồng Nhung phụ trách.");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nĐỀ BÀI: \nBài 8. Tìm bán kính hình cầu có thể tích tương đương với hình trụ tròn có bán kính R và chiều cao h.");
            Console.ResetColor();

            // Nhập bán kính và chiều cao từ người dùng
            Console.Write("\nNhập bán kính R của hình trụ tròn: ");
            double R = GetPositiveDoubleInput(); //GetPositiveDoubleInput() là Phương thức để đảm bảo người dùng nhập số dương
            Console.Write("Nhập chiều cao h của hình trụ tròn: ");
            double h = GetPositiveDoubleInput();

            double theTichTT = (double)(Math.PI * Math.Pow(R, 2) * h);
            Console.WriteLine($"Thể tích của hình trụ tròn có bán kính R và chiều cao h là: {theTichTT}");
            Console.WriteLine(new string('-', 104));

            // Tính bán kính của hình cầu có thể tích tương đương với hình trụ tròn
            double banKinhHC8 = (double)(Math.Pow((3 * theTichTT) / (4 * Math.PI), 1.0 / 3.0));
            Console.WriteLine($"\nBán kính của hình cầu có thể tích tương đương với hình trụ tròn có bán kính {R} và chiều cao {h} là: {banKinhHC8}");
        }

        /// <summary>
        /// Giải bài số 9 của phần 1: Tìm bán kính hình cầu có thể tích tương đương với hình hộp chữ nhật có số đo ba chiều là a, b, c.
        /// </summary>
        static void SolveP1Bai9() //Giải bài số 9 của phần 1
        {
            Console.WriteLine("Đây là phần do bạn Kiều Trinh phụ trách.");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nĐỀ BÀI: \nBài 9. Tìm bán kính hình cầu có thể tích tương đương với hình hộp chữ nhật có số đo ba chiều là a, b, c.");
            Console.ResetColor();

            //Nhập các số đo của hình hộp chữ nhật
            Console.Write("\nNhập chiều dài a của hình hộp chữ nhật: ");
            double a = GetPositiveDoubleInput();
            Console.Write("Nhập chiều rộng b của hình hộp chữ nhật: ");
            double b = GetPositiveDoubleInput();
            Console.Write("Nhập chiều cao c của hình hộp chữ nhật: ");
            double c = GetPositiveDoubleInput();

            //Tính thể tích hình hộp chữ nhật
            double theTichHCN = a * b * c;
            Console.WriteLine($"Thể tích của hình hộp chữ nhật có số đo ba chiều {a}; {b}; {c} là: {theTichHCN}");
            Console.WriteLine(new string('-', 104));

            // Tính bán kính của hình cầu có thể tích tương đương với hình hộp chữ nhật
            double banKinhHC9 = (double)(Math.Pow(((theTichHCN * 3) / (4 * Math.PI)), 1.0 / 3.0));
            Console.WriteLine($"\nBán kính của hình cầu có thể tích tương đương với hình hộp chữ nhật có số đo ba chiều {a}; {b}, {c} là: {banKinhHC9}");
        }

        /// <summary>
        /// Giải bài số 10 của phần 1: Một hình cầu có bán kính R và một hình trụ tròn có bán kính r và chiều cao h. 
        /// Nếu bán kính mỗi hình đều tăng lên gấp đôi, thì thể tích sẽ thay đôi như thể nào.
        /// </summary>
        static void SolveP1Bai10() //Giải bài số 10 của phần 1
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.WriteLine("Đây là phần do bạn Khánh Hào và Phương Nam phụ trách.");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nĐỀ BÀI: \nBài 10. Một hình cầu có bán kính R và một hình trụ tròn có bán kính r và chiều cao h." +
                            "\n        Nếu bán kính mỗi hình đều tăng lên gấp đôi, thì thể tích sẽ thay đôi như thể nào.");
            Console.ResetColor();

            //Nhập bán kính hình cầu, bán kính và chiều cao hình trụ
            Console.Write("Nhập bán kính hình cầu: ");
            double R = GetPositiveDoubleInput();
            Console.Write("Nhập bán kính hình trụ tròn: ");
            double r = GetPositiveDoubleInput();
            Console.Write("Nhập chiều cao hình trụ tròn: ");
            double h = GetPositiveDoubleInput();
            //Tính thể tích hình cầu ban đầu
            double Vc = Math.PI * Math.Pow(R, 3) * 4 / 3;
            Console.WriteLine("-------------------------------------[BAN ĐẦU]-------------------------------------");
            Console.WriteLine("Thể tích hình cầu ban đầu: {0}", Vc);

            //Tính thể tích hình trụ tròn ban đầu
            double Vt = Math.PI * Math.Pow(r, 2) * h;
            Console.WriteLine("Thể tích hình trụ tròn ban đầu: {0}", Vt);

            //Tính bán kính và thể tích hình cầu sau khi bán kính gấp đôi
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("----------------------------[SAU KHI BÁN KÍNH GẤP ĐÔI]-----------------------------");
            double Rn = 2 * R;
            double Vcs = Math.PI * Math.Pow(Rn, 3) * 4 / 3;
            Console.WriteLine("Thể tích hình cầu lúc sau là: {0}", Vcs);

            //Tính bán kính và thể tích hình trụ tròn sau khi bán kính gấp đôi
            double rn = 2 * r;
            double Vts = Math.PI * Math.Pow(rn, 2) * h;
            Console.WriteLine("Thể tích hình trụ tròn lúc sau: {0}", Vts);

            //Tính tỉ lệ thay đổi thể tích giữa thể tích mới và thể tích cũ
            Console.WriteLine("");
            Console.WriteLine("-------------------------------------[TỔNG KẾT]------------------------------------");
            double t = Vcs / Vc;
            double q = Vts / Vt;
            Console.WriteLine("Sau khi bán kính gấp đôi, thể tích hình cầu lúc sau gấp {0} lần so với thể tích hình cầu ban đầu.", t);
            Console.WriteLine("Sau khi bán kính gấp đôi, thể tích hình trụ tròn lúc sau gấp {0} lần so với thể tích hình trụ tròn ban đầu.", q);
        }

        /// <summary>
        /// Giải bài số 8 của phần 2: Nhập một mảng các số nguyên dương. Nhập 2 số nguyên dương N, M (N<M). 
        /// Cho biết trong mảng có bao nhiêu số thuộc đoạn [N,M], in các số này cùng vị trí của nó trong mảng.
        /// </summary>
        static void SolveP2Bai8() //Giải bài số 8 của phần 2
        {
            Console.WriteLine("Đây là phần do bạn Hồng Nhung phụ trách.");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nĐỀ BÀI: \nBài 8. Nhập một mảng các số nguyên dương, nhập 2 số nguyên dương N, M (N<M)                             " +
                                        "\n       Cho biết trong mảng có bao nhiêu số thuộc đoạn [N,M], in các số này cùng vị trí của nó trong mảng");
            Console.ResetColor();

            // Nhập mảng các số nguyên dương
            Console.Write("Nhập độ dài của mảng: ");
            int n;
            while ((!int.TryParse(Console.ReadLine(), out n)) || n <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nVUI LÒNG NHẬP ĐỘ DÀI MẢNG LÀ MỘT SỐ NGUYÊN DƯƠNG!");
                Console.ResetColor();
                Console.Write("Nhập độ dài của mảng: ");
            }

            int[] A = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Nhập phần tử thứ {i + 1}: ");
                A[i] = GetPositiveIntInput();
            }

            // Nhập hai số nguyên dương N và M, đảm bảo N < M
            int N, M;
            Console.Write("\n");
            Console.Write("===================================================\n");
            Console.WriteLine("Nhập đoạn giá trị bạn muốn kiểm tra");
            Console.Write("Nhập số nguyên dương N: ");
            N = GetPositiveIntInput();
            do
            {
                Console.Write("Nhập số nguyên dương M: ");
                M = GetPositiveIntInput();

                if (N >= M)
                {
                    Console.WriteLine("Số nguyên dương N phải bé hơn số nguyên dương M, mời bạn nhập lại.");
                }

            } while (N >= M);

            // Kiểm tra mảng và in ra các số thuộc đoạn [N, M] cùng với vị trí của chúng trong mảng
            Console.Write("\n");
            Console.WriteLine("=====================[KẾT QUẢ]=====================");
            Console.WriteLine($"Các số thuộc đoạn [{N}, {M}]:");
            int sum = 0;
            // In tổng của các số thuộc đoạn [N, M]
            for (int i = 0; i < n; i++)
            {
                if (A[i] >= N && A[i] <= M)
                {
                    Console.WriteLine($"A[{i}]: {A[i]}");
                    sum++;
                }
            }
            Console.WriteLine($"Trong mảng A, có {sum} số nguyên dương thuộc đoạn giá trị [{N}, {M}]");
        }

        /// <summary>
        /// Giải bài số 9 của phần 2: Nhập ma trận vuông cấp n. Cho biết trong ma trận vừa nhập có 2 hàng nào trùng nhau hay không, nếu có thì cho biết là 2 hàng nào. 
        /// </summary>
        static void SolveP2Bai9() //Giải bài số 9 của phần 2
        {
            Console.WriteLine("Đây là phần do bạn Kiều Trinh phụ trách.");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nĐỀ BÀI: \nBài 9. Cho dãy các quả cân sau : 1g, 2g, 4g, 8g, 16g, 32g, 64g, 128g, 256g. Nhập trọng lượng M (M < 512g), cho biết các quả cân sẽ sử dụng để cân vật có trọng lượng M (mỗi quả cân dùng tối đa 1 lần))");
            Console.ResetColor();

            int M;

            // Thông báo lỗi nếu người dùng nhập M không hợp lệ và nhập lại giá trị M
            Console.Write("Nhập trọng lượng M (M < 512g): ");
            while (!int.TryParse(Console.ReadLine(), out M) || M <= 0 || M >= 512)
            {
                Console.Write("Vui lòng nhập lại trọng lượng M hợp lệ (M < 512g):");
            }
            int[] ketQuaCanArray = new int[9]; // Khai báo mảng với số lượng phần tử cố định (9) lưu trữ các quả cân sẽ sử dụng để cân vật có trọng lượng M
            int[] danhSachQuaCan = { 1, 2, 4, 8, 16, 32, 64, 128, 256 };
            int index = 0; // Biến để theo dõi vị trí của mảng

            for (int i = danhSachQuaCan.Length - 1; i >= 0; i--)
            {
                while (M >= danhSachQuaCan[i])
                {
                    M -= danhSachQuaCan[i];
                    ketQuaCanArray[index] = danhSachQuaCan[i];
                    index++;
                }
            }
            Console.WriteLine($"Các quả cân được sử dụng để cân là: {string.Join(", ", ketQuaCanArray.Where(x => x != 0))}");
        }

        /// <summary>
        /// Giải bài số 10 của phần 2: Nhập số hạng đầu tiên của cấp số cộng, công sai của cấp số cộng, số lượng phần tử cần in. Sau đó in ra dãy cấp số cộng này.
        /// </summary>
        static void SolveP2Bai10() //Giải bài số 10 của phần 2
        {
            Console.WriteLine("Đây là phần do bạn Khánh Hào và Phương Nam phụ trách.");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nĐỀ BÀI: \nBài 10. Nhập số hạng đầu tiên của cấp số cộng, công sai của cấp số cộng, số lượng phần tử cần in. Sau đó in ra dãy cấp số cộng này.");
            Console.ResetColor();

            //Nhập số phần tử cần in
            Console.Write("Nhập số phần tử cần in: ");
            int n;
            while ((!int.TryParse(Console.ReadLine(), out n)) || n <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nVUI LÒNG NHẬP SỐ PHẦN TỬ CẦN IN LÀ MỘT SỐ NGUYÊN DƯƠNG!");
                Console.ResetColor();
                Console.Write("Nhập số phần tử cần in: ");
            }

            //Nhập số hạng đầu tiên của cấp số cộng
            Console.Write("Nhập số hạng đầu tiên của cấp số cộng: ");
            int u;
            while ((!int.TryParse(Console.ReadLine(), out u)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nVUI LÒNG NHẬP GIÁ TRỊ HỢP LỆ!");
                    Console.ResetColor();
                    Console.Write("Nhập số hạng đầu tiên của cấp số cộng: ");
                }

            //Nhập công sai của cấp số cộng
            Console.Write("Nhập công sai của cấp số cộng: ");
            int d;
            while ((!int.TryParse(Console.ReadLine(), out d)))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("\nVUI LÒNG NHẬP GIÁ TRỊ HỢP LỆ!");
                    Console.ResetColor();
                    Console.Write("Nhập công sai của cấp số cộng: ");
                }

            //In ra dãy cấp số cộng
            Console.Write("Dãy cấp số cộng: ");
            for (int i = 0; i < n; i++)
            {
                if (i < n - 1)
                    {
                    Console.Write("{0},", u + i * d);
                    }
                    else
                    {
                        Console.Write("{0}", u + i * d);
                    }
            }
        }

        /// <summary>
        /// Giải bài số 8 của phần 3: Nhập ma trận vuông cấp n. Tính tổng các phân tử chẵn nằm ở tam giác dưới đường chéo chính (kể cả đường chéo chính)
        /// </summary>
        static void SolveP3Bai8() //Giải bài số 8 của phần 3
        {
            Console.WriteLine("Đây là phần do bạn Hồng Nhung phụ trách.");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nĐỀ BÀI: \nBài 8. Nhập ma trận vuông cấp n. \n       Tính tổng các phân tử chẵn nằm ở tam giác dưới đường chéo chính (kể cả đường chéo chính)");
            Console.ResetColor();

            Console.Write("Nhập cấp của ma trận vuông: ");
            int n;
            while ((!int.TryParse(Console.ReadLine(), out n)) || n <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nVUI LÒNG NHẬP CẤP CỦA MA TRẬN VUÔNG LÀ MỘT SỐ NGUYÊN DƯƠNG!");
                Console.ResetColor();
                Console.Write("Nhập cấp của ma trận vuông: ");
            }

            double[,] matrix = TaoMaTranVuong(n);

            // Tính tổng các phần tử chẵn ở tam giác dưới đường chéo chính
            double sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (matrix[i, j] % 2 == 0)
                    {
                        sum += matrix[i, j];

                    }
                }
            }
            Console.WriteLine($"\nTổng các phần tử chẵn ở tam giác dưới đường chéo chính (kể cả đường chéo chính) là: {sum}");
        }


        /// <summary>
        /// Giải bài số 9 của phần 3: Nhập ma trận vuông cấp n. Cho biết trong ma trận vừa nhập có 2 hàng nào trùng nhau hay không nếu có thì cho biết là 2 hàng nào.
        /// </summary>
        static void SolveP3Bai9()
        {
            Console.WriteLine("Đây là phần do bạn Kiều Trinh phụ trách.");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nĐỀ BÀI: \nBài 9. Nhập ma trận vuông cấp n. Cho biết trong ma trận vừa nhập có 2 hàng nào trùng nhau hay không nếu có thì cho biết là 2 hàng nào.");
            Console.ResetColor();

            Console.Write("Nhập cấp của ma trận vuông (n): ");
            int n;
            while ((!int.TryParse(Console.ReadLine(), out n)) || n <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nVUI LÒNG NHẬP CẤP CỦA MA TRẬN VUÔNG LÀ MỘT SỐ NGUYÊN DƯƠNG!");
                Console.ResetColor();
                Console.Write("Nhập cấp của ma trận vuông: ");
            }

            double[,] matrix = TaoMaTranVuong(n);

            Dictionary<string, HashSet<int>> hangTrungNhau = KiemTraHangTrungNhau(matrix, n);

            if (hangTrungNhau.Count > 0)
            {
                foreach (var kvp in hangTrungNhau)  //kvp là key value pair
                {
                    Console.WriteLine($"Hàng {string.Join(", ", kvp.Value)} trùng nhau: {kvp.Key}");
                }
            }
            else
            {
                Console.WriteLine("Không có hàng nào trùng nhau.");
            }
        }

        /// <summary>
        /// Kiểm tra xem hai hàng trong ma trận vuông có trùng nhau hay không.
        /// </summary>
        static Dictionary<string, HashSet<int>> KiemTraHangTrungNhau(double[,] maTran, int n)
        {
            // Khởi tạo một Dictionary để lưu các hàng trùng nhau
            var hangTrungNhau = new Dictionary<string, HashSet<int>>();

            // Duyệt qua các hàng của ma trận
            for (int i = 0; i < n - 1; i++)
            {
                // Duyệt qua các hàng còn lại để so sánh với hàng trước đó
                for (int j = i + 1; j < n; j++)
                {
                    // Khởi tạo biến trung để kiểm tra xem 2 hàng có trùng nhau hay không
                    bool trung = true;

                    // Khởi tạo một StringBuilder để lưu giá trị của hàng 
                    StringBuilder giaTriHang = new StringBuilder($"{maTran[i, 0]}");

                    // Khởi tạo một HashSet để lưu index của các hàng trùng nhau
                    HashSet<int> danhSachHangTrungNhau = new HashSet<int> { i + 1, j + 1 };

                    // Duyệt qua các cột của ma trận
                    for (int k = 1; k < n; k++)
                    {
                        // Thêm giá trị của cột vào StringBuilder
                        giaTriHang.Append($", {maTran[i, k]}");

                        // Nếu giá trị của cột tại hàng i khác giá trị của cột tại hàng j thì 2 hàng không trùng nhau
                        if (maTran[i, k] != maTran[j, k])
                        {
                            trung = false;
                            break;
                        }
                    }

                    if (trung)
                    {
                        // Nếu 2 hàng trùng nhau thì thêm giá trị của hàng vào Dictionary
                        if (hangTrungNhau.ContainsKey(giaTriHang.ToString()))
                        {
                            // Nếu giá trị của hàng đã tồn tại trong Dictionary thì thêm index của hàng vào HashSet
                            foreach (var hangIndex in danhSachHangTrungNhau)
                            {
                                hangTrungNhau[giaTriHang.ToString()].Add(hangIndex);
                            }
                        }
                        else
                        {
                            // Nếu giá trị của hàng chưa tồn tại trong Dictionary thì thêm giá trị của hàng và index của hàng vào Dictionary
                            hangTrungNhau[giaTriHang.ToString()] = danhSachHangTrungNhau;
                        }
                    }
                }
            }
            return hangTrungNhau;
        }

        /// <summary>
        /// Giải bài số 10 của phần 3: Nhập ma trận vuông cấp n. In các phần tử của ma trận này dọc theo phương của đường chéo chính.
        /// </summary>
        static void SolveP3Bai10() //Giải bài số 10 của phần 3
        {
            Console.WriteLine("Đây là phần do bạn Khánh Hào và Phương Nam phụ trách.");

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nĐỀ BÀI: \nBài 10. Nhập ma trận vuông cấp n. In các phần tử của ma trận này dọc theo phương của đường chéo chính.");
            Console.ResetColor();

            //Nhập cấp của ma trận vuông
            Console.Write("Nhập cấp của ma trận vuông: ");
            int n;
            while ((!int.TryParse(Console.ReadLine(), out n)) || n <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("\nVUI LÒNG NHẬP CẤP CỦA MA TRẬN VUÔNG LÀ MỘT SỐ NGUYÊN DƯƠNG!");
                Console.ResetColor();
                Console.Write("Nhập cấp của ma trận vuông: ");
            }

            // Gọi phương thức TaoMaTranVuong() để tạo ma trận vuông cấp n
            double[,] matrix = TaoMaTranVuong(n); 
            //In ra các phần tử của ma trận dọc theo đường chéo chính
            Console.WriteLine("\nCác phần tử của ma trận dọc theo đường chéo chính:");

            for (int k = 0; k < n; k++)
            {
                for (int i = 0, j = n - 1 - k; i <= k; i++, j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int k = 1; k < n; k++)
            {
                for (int i = k, j = 0; i < n; i++, j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// Giải bài Lẻ phần 4 - Tính tiền ở, tiền ăn và phí phục vụ cho khách sạn Five Stars.
        /// </summary>
        static void SolveP4Lẻ()
        {
            Console.WindowWidth = 107; //Cài đặt độ rộng mặc định của cửa sổ console

            Console.Write(Environment.NewLine);
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("\n+" + new string('-', 37) + "[BẢNG GIÁ KHÁCH SẠN FIVE STARS]" + new string('-', 37) + "+");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("|                                       Các gói dịch vụ gồm:                                              |");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("|                        Đồng:                                                                            |");
            Console.WriteLine("|                            Chi phi lưu trú (Tiền ở) : 80 nghìn đồng/ngày                                |");
            Console.WriteLine("|                            Chi phi ăn uống (Tiền ăn): 120 nghìn đồng/bữa                                |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                        Bạc:                                                                             |");
            Console.WriteLine("|                            Chi phi lưu trú (Tiền ở) : 135 nghìn đồng/ngày                               |");
            Console.WriteLine("|                            Chi phi ăn uống (Tiền ăn): 150 nghìn đồng/bữa                                |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                        Vàng:                                                                            |");
            Console.WriteLine("|                            Chi phi lưu trú (Tiền ở) : 180 nghìn đồng/ngày                               |");
            Console.WriteLine("|                            Chi phi ăn uống (Tiền ăn): 200 nghìn đồng/bữa                                |");
            Console.WriteLine("|                                                                                                         |");
            Console.WriteLine("|                       Phí phục vụ: 15%/tổng tiền ở và tiền ăn                                           |");
            Console.Write("+" + new string('-', 105) + "+");
            Console.ResetColor();

            //Thực hiện việc nhập số lượng khách hàng cần xuất hóa đơn
            Console.Write("\n\nNhập số lượng khách: ");
            int soLuongKhach;

            while (!int.TryParse(Console.ReadLine(), out soLuongKhach) || soLuongKhach <= 0)
            {
                Console.WriteLine("Vui lòng nhập một số nguyên dương.");
                Console.Write("Nhập số lượng khách: ");
            }

            // Khai báo mảng nhiều chiều để lưu thông tin của từng khách
            string[,] thongTinKhach = new string[soLuongKhach, 3]; // 3 cột cho họ tên, số ngày ở, số bữa ăn

            // Nhập thông tin cho từng khách
            for (int i = 0; i < soLuongKhach; i++)
            {
            thongTinKhach:
                Console.WriteLine($"\nNhập thông tin cho khách thứ {i + 1}:");

                Console.Write("Họ tên: ");
                string hoTen = "";
                while (true)
                {
                    hoTen = Console.ReadLine().ToUpper();
                    if (IsAlphabetical(hoTen))
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Vui lòng nhập họ tên chỉ chứa các kí tự trong bảng chữ cái.");
                        Console.Write("Họ tên: ");
                    }
                }
                thongTinKhach[i, 0] = hoTen;

                Console.Write("Số ngày ở: ");
                int soNgayO;
                while (!int.TryParse(Console.ReadLine(), out soNgayO) || soNgayO < 0)
                {
                    Console.WriteLine("Vui lòng nhập số ngày ở hợp lệ.");
                    Console.Write("Số ngày ở: ");
                }
                thongTinKhach[i, 1] = soNgayO.ToString();

                Console.Write("Số bữa ăn: ");
                int soBuaAn;
                while (!int.TryParse(Console.ReadLine(), out soBuaAn) || soBuaAn < 0)
                {
                    Console.WriteLine("Vui lòng nhập số bữa ăn hợp lệ.");
                    Console.Write("Số bữa ăn: ");
                }
                thongTinKhach[i, 2] = soBuaAn.ToString();

                // Lấy thông tin từ mảng
                hoTen = thongTinKhach[i, 0];
                soNgayO = int.Parse(thongTinKhach[i, 1]);
                soBuaAn = int.Parse(thongTinKhach[i, 2]);

                // Tính tiền ở, tiền ăn và phí phục vụ cho từng khách
                Console.WriteLine($"\nCác gói dịch vụ được đánh dấu như sau:");
                Console.WriteLine("1. Vàng");
                Console.WriteLine("2. Bạc");
                Console.WriteLine("3. Đồng");
                int goiDichVu;
                string tenGoiDichVu = "";
                Console.Write($"Hãy nhập số tương ứng với gói dịch vụ mà khách hàng {hoTen} đã chọn: ");

                while (!int.TryParse(Console.ReadLine(), out goiDichVu) || (goiDichVu != 1 && goiDichVu != 2 && goiDichVu != 3))
                {
                    Console.WriteLine("Vui lòng nhập đúng với số thứ tự mà gói dịch vụ đã được đánh dấu.");
                    Console.Write($"Khách hàng {hoTen} đã lựa chọn gói dịch vụ: ");
                }
                switch (goiDichVu)
                {
                    case 1:
                        tenGoiDichVu = "Vàng";
                        break;
                    case 2:
                        tenGoiDichVu = "Bạc";
                        break;
                    case 3:
                        tenGoiDichVu = "Đồng";
                        break;
                }

                //Kiểm tra lại thông tin khách hàng
                Console.WindowWidth = 105; //Cài đặt độ rộng mặc định của cửa sổ console
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("\n\n*" + new string('*', 41) + "[XÁC MINH THÔNG TIN]" + new string('*', 41) + "*");
                Console.WriteLine("* Họ và tên: {0, -90}*", hoTen);
                Console.WriteLine("* Số ngày ở: {0, -90}*", soNgayO);
                Console.WriteLine("* Số bữa ăn: {0, -90}*", soBuaAn);
                Console.WriteLine("* Gói dịch vụ: {0, -88}*", tenGoiDichVu);
                Console.Write(new string('*', 104));
                Console.ResetColor();
            TraLoi:
                // Nhập lựa chọn sau khi kiểm tra thông tin
                Console.Write("\n\n- Nhập '1' nếu thông tin trên là 'Chính xác', và '0' nếu 'Chưa chính xác': ");
                int check = int.Parse(Console.ReadLine());
                // Kiểm tra lựa chọn hợp lệ       
                if (check == 0)
                {

                    Console.WriteLine("Quý khách vui lòng nhập lại thông tin!\n");
                    goto thongTinKhach;
                }
                else if (check == 1)
                {
                    // Hiển thị thông báo đăng ký thành công
                    Console.Write(Environment.NewLine);
                    foreach (var c in "...VUI LÒNG CHỜ TRONG GIÂY LÁT...")
                    {
                        Console.Write(c);
                        System.Threading.Thread.Sleep(96);
                    }
                    Console.Write(Environment.NewLine);
                    Console.Write(Environment.NewLine);
                    System.Threading.Thread.Sleep(1000);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("ĐÃ THỰC HIỆN XÁC THỰC THÀNH CÔNG! ");
                    Console.ResetColor();
                    System.Threading.Thread.Sleep(1500);
                }
                else
                {
                    Console.WriteLine("Lựa chọn không hợp lệ. Vui lòng chọn lại.");
                    goto TraLoi;
                }

                switch (goiDichVu)
                {
                    case 1:

                        // Lấy thông tin từ mảng
                        hoTen = thongTinKhach[i, 0];
                        soNgayO = int.Parse(thongTinKhach[i, 1]);
                        soBuaAn = int.Parse(thongTinKhach[i, 2]);

                        int tienO = 180000 * soNgayO;
                        int tienAn = 200000 * soBuaAn;

                        double phiPhucVu = (tienO + tienAn) * 0.15;
                        double tongTien = tienO + tienAn + phiPhucVu;


                        // In hóa đơn cho từng khách
                        InHoaDon(thongTinKhach[i, 0], thongTinKhach[i, 1], thongTinKhach[i, 2], tienO, tienAn, phiPhucVu, tongTien);
                        Console.WriteLine("\n");

                        break;
                    case 2:

                        // Lấy thông tin từ mảng
                        hoTen = thongTinKhach[i, 0];
                        soNgayO = int.Parse(thongTinKhach[i, 1]);
                        soBuaAn = int.Parse(thongTinKhach[i, 2]);

                        tienO = 135000 * soNgayO;
                        tienAn = 150000 * soBuaAn;

                        phiPhucVu = (tienO + tienAn) * 0.15;
                        tongTien = tienO + tienAn + phiPhucVu;


                        // In hóa đơn cho từng khách
                        InHoaDon(thongTinKhach[i, 0], thongTinKhach[i, 1], thongTinKhach[i, 2], tienO, tienAn, phiPhucVu, tongTien);
                        Console.WriteLine("\n");
                        break;

                    case 3:

                        // Lấy thông tin từ mảng
                        hoTen = thongTinKhach[i, 0];
                        soNgayO = int.Parse(thongTinKhach[i, 1]);
                        soBuaAn = int.Parse(thongTinKhach[i, 2]);

                        tienO = 80000 * soNgayO;
                        tienAn = 120000 * soBuaAn;

                        phiPhucVu = (tienO + tienAn) * 0.15;
                        tongTien = tienO + tienAn + phiPhucVu;

                        // In hóa đơn cho từng khách
                        InHoaDon(thongTinKhach[i, 0], thongTinKhach[i, 1], thongTinKhach[i, 2], tienO, tienAn, phiPhucVu, tongTien);
                        Console.WriteLine("\n");
                        break;


                }
            }
        }


        /// <summary>
        /// In hóa đơn cho khách hàng.
        /// </summary>
        /// <param name="hoTen">Họ tên khách hàng.</param>
        /// <param name="soNgayO">Số ngày ở.</param>
        /// <param name="soBuaAn">Số bữa ăn.</param>
        /// <param name="tienO">Tiền ở.</param>
        /// <param name="tienAn">Tiền ăn.</param>
        /// <param name="phiPhucVu">Phí phục vụ.</param>
        /// <param name="tongTien">Tổng tiền phải thanh toán.</param>
        static void InHoaDon(string hoTen, string soNgayO, string soBuaAn, double tienO, double tienAn, double phiPhucVu, double tongTien)
        {
            Console.WindowWidth = 107; //Cài đặt độ rộng mặc định của cửa sổ console

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;


            Console.WriteLine("\n\n*" + new string('*', 48) + "[HÓA ĐƠN]" + new string('*', 48) + "*");
            Console.WriteLine("*                                                                                                       * ");
            Console.WriteLine("*  Khách sạn Five Stars                                                                                 * ");
            Console.WriteLine("*                                                                                                       * ");
            Console.WriteLine("*  Hóa đơn khách sạn                                                                                    * ");
            Console.WriteLine("*                                                                                                       * ");
            Console.WriteLine("*  Quí Ông(Bà): {0,-88}* ", hoTen);
            Console.WriteLine("*                                                                                                       * ");
            Console.WriteLine("*  Số ngày ở: {0,-14}Số bữa ăn: {1,-36}                             *", soNgayO, soBuaAn);
            Console.WriteLine("*                                                                                                       * ");
            Console.WriteLine("*  Tiền ở: {0,-17}Tiền ăn: {1,-16}Phí phục vụ: {2,-9}                             * ", tienO, tienAn, phiPhucVu);
            Console.WriteLine("*                                                                                                       * ");
            Console.WriteLine("*  Tổng cộng chi phí: {0,-82}*", tongTien);
            Console.WriteLine("*                                                                                                       * ");
            Console.WriteLine("*                          Hân hạnh phục vụ quí khách!                                                  * ");
            Console.Write(new string('*', 107));
            Console.ResetColor();
        }
        static bool IsAlphabetical(string input)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            foreach (char c in input)
            {
                if (!char.IsLetter(c) && c != ' ')
                {
                    return false;
                }
            }
            return true;
        }
    }
}