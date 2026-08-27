using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSLT.s3
{

    internal class Exercise02
    {
        static void Bai1()
        {
            Console.Write("Nhập chỉ số điện cũ (kWh): ");
            float csd_cu = float.Parse(Console.ReadLine());
            
            float csd_moi;

            do
            {
                Console.Write("Nhập chỉ số điện mới (kwh): ");
                csd_moi = float.Parse(Console.ReadLine());
                if (csd_moi >= csd_cu)
                    break;
                else
                    Console.WriteLine("\t*** Chí số mới phải lớn hơn hoặc bằng chỉ số cũ");
            } while (true);
            float tieuThu = csd_moi - csd_cu;
            float dongia = 3059f;
            decimal tienDien = (decimal)(tieuThu * dongia);
            decimal vat = (decimal)(tieuThu * 0.08f);
            Console.WriteLine($"Số điện tiêu thụ: {tieuThu} kWh");
            Console.WriteLine($"Tiền điện chưa thuế: {tienDien}");
            Console.WriteLine($"Tiền thuế VAT: {vat}");
            Console.WriteLine($"Tổng thanh toán: {tienDien + vat}");

            
        }
        static void Bai2()
        {
            Console.Write("Chiều cao (m)(vd:1,68): ");
            double chieuCao = double.Parse(Console.ReadLine());

            Console.Write("Cân nặng (kg): ");
            double canNang = double.Parse(Console.ReadLine());

            // Công thức BMI đúng
            double bmi = canNang / (chieuCao * chieuCao);

            string phanLoai;
            if (bmi < 18.5)
                phanLoai = "Gầy (Thiếu cân)";
            else if (bmi < 23.0)
                phanLoai = "Bình thường (Lý tưởng)";
            else if (bmi < 25.0)
                phanLoai = "Thừa cân (Tiền béo phì)";
            else
                phanLoai = "Béo phì";

            // Tính cân nặng lý tưởng theo khoảng BMI
            double canNangMin = 18.5 * (chieuCao * chieuCao);
            double canNangMax = 22.9 * (chieuCao * chieuCao);

            // In ra với định dạng F2 (2 chữ số thập phân)
            Console.WriteLine($"Chỉ số BMI của bạn: {bmi:F2}");
            Console.WriteLine($"Phân loại sức khỏe: {phanLoai}");
            Console.WriteLine($"Khuyến dùng: Cân nặng lý tưởng của bạn nên từ {canNangMin:F2} kg đến {canNangMax:F2} kg.");
        }
        static void Bai3() 
        {
            decimal rateUSD = 25400m;
            decimal rateEUR = 27200m;
            decimal rateJPY = 165m;
            decimal rateGBP = 32100m;

            Console.Write("Nhập số tiền VND: ");
            decimal vnd = decimal.Parse(Console.ReadLine());

            Console.Write("Chọn ngoại tệ (1-USD, 2-EUR, 3-JPY, 4-GBP): ");
            int choice = int.Parse(Console.ReadLine());

            decimal fee = vnd * 0.005m;
            decimal vndAfterFee = vnd - fee;

            decimal foreignAmount = 0;
            string symbol = "";

            switch (choice)
            {
                case 1:
                    foreignAmount = vndAfterFee / rateUSD;
                    symbol = "USD";
                    break;
                case 2: 
                    foreignAmount = vndAfterFee / rateEUR;
                    symbol = "EUR";
                    break;
                case 3: 
                    foreignAmount = vndAfterFee / rateJPY;
                    symbol = "JPY";
                    break;
                case 4: 
                    foreignAmount = vndAfterFee / rateGBP;
                    symbol = "GBP";
                    break;
                default:
                    Console.WriteLine("Lựa chọn không hợp lệ!");
                    return;
            }

            Console.WriteLine($"Phí dịch vụ (0.5%): {fee:N0} VND");
            Console.WriteLine($"Số tiền VND tính đổi: {vndAfterFee:N0} VND");
            Console.WriteLine($"Số tiền {symbol} nhận được: {foreignAmount:F2} {symbol}");
        }
        static void Bai4()
        {
            Console.Write("Nhập ngày sinh (dd/MM/yyyy): ");
            string input = Console.ReadLine();

            if (!DateTime.TryParseExact(
                    input,
                    "dd/MM/yyyy",
                    CultureInfo.InvariantCulture,
                    DateTimeStyles.None,
                    out DateTime birthDate))
            {
                Console.WriteLine("Định dạng ngày không hợp lệ!");
                return;
            }

            DateTime today = DateTime.Now.Date;

            int age = today.Year - birthDate.Year;
            if (birthDate > today.AddYears(-age))
            {
                age--;
            }

            TimeSpan livedDays = today - birthDate;

            DateTime nextBirthday = new DateTime(today.Year, birthDate.Month, birthDate.Day);
            if (nextBirthday < today)
            {
                nextBirthday = nextBirthday.AddYears(1);
            }

            TimeSpan daysUntilBirthday = nextBirthday - today;

            Console.WriteLine($"Tuổi hiện tại: {age} tuổi");
            Console.WriteLine($"Bạn đã sống tổng cộng: {livedDays.Days:N0} ngày");
            Console.WriteLine($"Sinh nhật tiếp theo còn: {daysUntilBirthday.Days} ngày nữa");
        }
        static void Bai5() 
        {
            Console.Write("Nhập điểm C# (4 TC): ");
            double diemCSharp = double.Parse(Console.ReadLine());
            int tcCSharp = 4;

            Console.Write("Nhập điểm Toán rời rạc (3 TC): ");
            double diemToan = double.Parse(Console.ReadLine());
            int tcToan = 3;

            Console.Write("Nhập điểm Tiếng Anh (2 TC): ");
            double diemAnh = double.Parse(Console.ReadLine());
            int tcAnh = 2;

            double diemTB = (diemCSharp * tcCSharp + diemToan * tcToan + diemAnh * tcAnh)
                            / (tcCSharp + tcToan + tcAnh);

            string diemChu, xepLoai;
            double gpa;

            if (diemTB >= 8.5)
            {
                diemChu = "A"; gpa = 4.0; xepLoai = "Xuất sắc / Giỏi";
            }
            else if (diemTB >= 7.0)
            {
                diemChu = "B"; gpa = 3.0; xepLoai = "Khá";
            }
            else if (diemTB >= 5.5)
            {
                diemChu = "C"; gpa = 2.0; xepLoai = "Trung bình";
            }
            else if (diemTB >= 4.0)
            {
                diemChu = "D"; gpa = 1.0; xepLoai = "Yếu";
            }
            else
            {
                diemChu = "F"; gpa = 0.0; xepLoai = "Kém (Trượt)";
            }

            Console.WriteLine($"Điểm TB Thang 10: {diemTB:F2}");
            Console.WriteLine($"Điểm Chữ Quy Đổi: {diemChu}");
            Console.WriteLine($"Điểm GPA Thang 4: {gpa:F1}");
            Console.WriteLine($"Xếp Loại Học Lực: {xepLoai}");
        }
        static void Bai6() 
        {
            Console.Write("Nhập họ tên thô: ");
            string rawName = Console.ReadLine();

            string[] parts = rawName.Trim()
                                    .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < parts.Length; i++)
            {
                string word = parts[i].ToLower();
                parts[i] = char.ToUpper(word[0]) + word.Substring(1);
            }
            string fullName = string.Join(" ", parts);

            string ho = parts[0];
            string ten = parts[parts.Length - 1];
            string tenDem = parts.Length > 2 ? string.Join(" ", parts, 1, parts.Length - 2) : "";

            string normalized = fullName.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            foreach (char c in normalized)
            {
                var uc = CharUnicodeInfo.GetUnicodeCategory(c);
                if (uc != UnicodeCategory.NonSpacingMark)
                    sb.Append(c);
            }
            string noDiacritics = sb.ToString().Normalize(NormalizationForm.FormC).ToLower();

            string[] normParts = noDiacritics.Split(' ', StringSplitOptions.RemoveEmptyEntries);
            string username = normParts[normParts.Length - 1] + "." + string.Join("", normParts, 0, normParts.Length - 1);

            string email = username + "@company.edu.vn";

            Console.WriteLine($"Họ tên chuẩn hóa: {fullName}");
            Console.WriteLine($"Họ: {ho} | Tên đệm: {tenDem} | Tên: {ten}");
            Console.WriteLine($"Username tạo tự động: {username}");
            Console.WriteLine($"Email cấp phát: {email}");
        }
        static void Bai7() 
        {
            Console.Write("Quãng đường (km): ");
            double quangDuong = double.Parse(Console.ReadLine());

            Console.Write("Mức tiêu hao (L/100km): ");
            double tieuHao = double.Parse(Console.ReadLine());

            Console.Write("Giá xăng (VND/Lít): ");
            decimal giaXang = decimal.Parse(Console.ReadLine());

            Console.Write("Số người đi: ");
            int soNguoi = int.Parse(Console.ReadLine());

            double tongLit = (quangDuong / 100) * tieuHao;

            decimal tongChiPhi = (decimal)tongLit * giaXang;

            decimal chiPhiMoiNguoi = tongChiPhi / soNguoi;
            chiPhiMoiNguoi = Math.Ceiling(chiPhiMoiNguoi / 1000) * 1000;

            Console.WriteLine($"Tổng nhiên liệu tiêu thụ: {tongLit:F2} Lít");
            Console.WriteLine($"Tổng chi phí xăng dầu: {tongChiPhi:N0} VND");
            Console.WriteLine($"Chi phí mỗi người: {chiPhiMoiNguoi:N0} VND");
        }
        static void Bai8() 
        {
            string systemOTP = "839201";
            DateTime creationTime = DateTime.Now;

            Console.Write("Nhập mã OTP: ");
            string userOTP = Console.ReadLine();

            Console.Write("Nhập số phút trôi qua: ");
            int minutes;
            int.TryParse(Console.ReadLine(), out minutes);

            Console.Write("Nhập số giây trôi qua: ");
            int seconds;
            int.TryParse(Console.ReadLine(), out seconds);

            TimeSpan elapsed = new TimeSpan(0, minutes, seconds);

            Console.WriteLine("\n--- KẾT QUẢ ---");

            if (userOTP.Length != 6 || !int.TryParse(userOTP, out _))
            {
                Console.WriteLine("LỖI: Mã OTP phải gồm 6 ký tự số.");
            }
  
            else if (userOTP != systemOTP)
            {
                Console.WriteLine("LỖI: Mã OTP không đúng.");
            }
            
            else if (elapsed.TotalSeconds > 300) 
            {
                Console.WriteLine("LỖI: Mã OTP đã hết hạn.");
            }
            else
            {
                Console.WriteLine("THÀNH CÔNG - Giao dịch đã được phê duyệt.");
            }
        }
        static void Bai9() 
        {
            Console.Write("Nhập lương Gross (VND): ");
            decimal gross = decimal.Parse(Console.ReadLine());

            Console.Write("Nhập số người phụ thuộc: ");
            int soNguoiPhuThuoc = int.Parse(Console.ReadLine());

            decimal giamTruBH = gross * 0.105m;

            decimal giamTruBanThan = 11000000m;
            decimal giamTruNguoiPhuThuoc = soNguoiPhuThuoc * 4400000m;

            decimal thuNhapChiuThue = gross - giamTruBH - giamTruBanThan - giamTruNguoiPhuThuoc;
            if (thuNhapChiuThue < 0) thuNhapChiuThue = 0;

            decimal thueTNCN = 0;
            decimal tn = thuNhapChiuThue;

            if (tn <= 5000000)
            {
                thueTNCN = tn * 0.05m;
            }
            else if (tn <= 10000000)
            {
                thueTNCN = 5000000 * 0.05m + (tn - 5000000) * 0.10m;
            }
            else if (tn <= 18000000)
            {
                thueTNCN = 5000000 * 0.05m + 5000000 * 0.10m + (tn - 10000000) * 0.15m;
            }
            else if (tn <= 32000000)
            {
                thueTNCN = 5000000 * 0.05m + 5000000 * 0.10m + 8000000 * 0.15m + (tn - 18000000) * 0.20m;
            }
            else if (tn <= 52000000)
            {
                thueTNCN = 5000000 * 0.05m + 5000000 * 0.10m + 8000000 * 0.15m + 14000000 * 0.20m + (tn - 32000000) * 0.25m;
            }
            else if (tn <= 80000000)
            {
                thueTNCN = 5000000 * 0.05m + 5000000 * 0.10m + 8000000 * 0.15m + 14000000 * 0.20m + 20000000 * 0.25m + (tn - 52000000) * 0.30m;
            }
            else
            {
                thueTNCN = 5000000 * 0.05m + 5000000 * 0.10m + 8000000 * 0.15m + 14000000 * 0.20m + 20000000 * 0.25m + 28000000 * 0.30m + (tn - 80000000) * 0.35m;
            }

            decimal net = gross - giamTruBH - thueTNCN;

            Console.WriteLine($"Giảm trừ Bảo hiểm (10.5%): {giamTruBH:N0} VND");
            Console.WriteLine($"Thu nhập chịu thuế: {thuNhapChiuThue:N0} VND");
            Console.WriteLine($"Thuế TNCN phải nộp: {thueTNCN:N0} VND");
            Console.WriteLine($"LƯƠNG NET THỰC NHẬN: {net:N0} VND");
        }
        static void Bai10()  
        {
            Console.Write("Nhập mã sản phẩm: ");
            string productCode = Console.ReadLine();

            Console.Write("Nhập tên sản phẩm: ");
            string productName = Console.ReadLine();

            Console.Write("Nhập số lượng tồn kho (có thể bỏ trống): ");
            string inputQty = Console.ReadLine();
            int? quantity = null;
            if (!string.IsNullOrWhiteSpace(inputQty))
            {
                if (int.TryParse(inputQty, out int q))
                    quantity = q;
                else
                    Console.WriteLine("Cảnh báo: Số lượng nhập không hợp lệ!");
            }

            Console.Write("Nhập ngày nhập hàng (yyyy-MM-dd, có thể bỏ trống): ");
            string inputDate = Console.ReadLine();
            DateTime? restockDate = null;
            if (!string.IsNullOrWhiteSpace(inputDate))
            {
                if (DateTime.TryParse(inputDate, out DateTime d))
                    restockDate = d;
                else
                    Console.WriteLine("Cảnh báo: Ngày nhập không hợp lệ!");
            }

            int minThreshold = 10;
            int qtyDisplay = quantity ?? 0;

            string status;
            if (quantity == null || quantity == 0)
                status = "OutOfStock";
            else if (quantity < minThreshold)
                status = "LowStock";
            else
                status = "InStock";

            Console.WriteLine($"\n--- THÔNG TIN SẢN PHẨM ---");
            Console.WriteLine($"Sản phẩm: {productName} (Mã: {productCode})");
            Console.WriteLine($"Số lượng hiện tại: {qtyDisplay} {(quantity == null ? "(Cảnh báo: Dữ liệu trống)" : "")}");
            Console.WriteLine($"Trạng thái kho: {status}");
            Console.WriteLine($"Dự kiến nhập hàng: {restockDate?.ToString("dd/MM/yyyy") ?? "Chưa có lịch nhập hàng"}");

            Console.WriteLine("\n--> Bấm phím bất kỳ để tiếp tục sang Bài 11...");
            Console.ReadKey();
        }
        static void Bai11()
        {
            Console.Write("Nhập số tiền gửi (VND): ");
            decimal P = decimal.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhập lãi suất năm (%): ");
            double r = double.Parse(Console.ReadLine() ?? "0");

            Console.Write("Nhập thời gian gửi (tháng): ");
            int n = int.Parse(Console.ReadLine() ?? "0");

            decimal laiDon = P * (decimal)(r / 100) * (n / 12m);

            double tongTienLaiiKep = (double)P * Math.Pow(1 + (r / 100) / 12, n);
            decimal tongLaiKep = (decimal)tongTienLaiiKep - P;
            decimal chenhLech = tongLaiKep - laiDon;

            Console.WriteLine($"Tổng tiền lãi (Lãi đơn): {laiDon:N0} VND");
            Console.WriteLine($"Tổng tiền lãi (Lãi kép): {tongLaiKep:N0} VND");
            Console.WriteLine($"Lợi nhuận chênh lệch: {chenhLech:N0} VND (Lãi kép tối ưu hơn)");
        }
        static void Bai12() 
        {
            Console.Write("Nhập văn bản gốc: ");
            string originalText = Console.ReadLine();

            Console.Write("Nhập khóa dịch chuyển (1-25): ");
            int k = int.Parse(Console.ReadLine());

            string encrypted = "";
            foreach (char c in originalText)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    encrypted += (char)('A' + (c - 'A' + k) % 26);
                }
                else if (c >= 'a' && c <= 'z')
                {
                    encrypted += (char)('a' + (c - 'a' + k) % 26);
                }
                else
                {
                    encrypted += c;
                }
            }

            string decrypted = "";
            foreach (char c in encrypted)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    decrypted += (char)('A' + (c - 'A' - k + 26) % 26);
                }
                else if (c >= 'a' && c <= 'z')
                {
                    decrypted += (char)('a' + (c - 'a' - k + 26) % 26);
                }
                else
                {
                    decrypted += c;
                }
            }

            Console.WriteLine($"Văn bản mã hóa: {encrypted}");
            Console.WriteLine($"Văn bản giải mã: {decrypted}");
        }
        static void Bai13() 
        {
            Console.Write("Nhập loại xe (Motorbike/Car/Truck): ");
            string vehicleType = Console.ReadLine();

            Console.Write("Nhập giờ vào (yyyy-MM-dd HH:mm): ");
            DateTime checkIn = DateTime.Parse(Console.ReadLine());

            Console.Write("Nhập giờ ra (yyyy-MM-dd HH:mm): ");
            DateTime checkOut = DateTime.Parse(Console.ReadLine());

            TimeSpan duration = checkOut - checkIn;
            double totalHours = duration.TotalHours;
            int hoursRounded = (int)Math.Ceiling(totalHours);

            decimal fee = 0;
            decimal first2hFee = 0;
            decimal extraFee = 0;

            if (vehicleType.ToLower() == "motorbike")
            {
                first2hFee = 5000;
                if (hoursRounded > 2)
                    extraFee = (hoursRounded - 2) * 2000;
            }
            else if (vehicleType.ToLower() == "car")
            {
                first2hFee = 20000;
                if (hoursRounded > 2)
                    extraFee = (hoursRounded - 2) * 10000;
            }
            else if (vehicleType.ToLower() == "truck")
            {
                first2hFee = 50000;
                if (hoursRounded > 2)
                    extraFee = (hoursRounded - 2) * 25000;
            }

            fee = first2hFee + extraFee;

            if (checkIn.Date != checkOut.Date)
            {
                fee += 30000;
            }

            Console.WriteLine("\n--- HÓA ĐƠN ---");
            Console.WriteLine($"Tổng thời gian đỗ: {totalHours:F2} giờ -> Tính phí: {hoursRounded} giờ");
            Console.WriteLine($"Phí 2 giờ đầu: {first2hFee:N0} VND");
            Console.WriteLine($"Phí giờ tiếp theo: {extraFee:N0} VND");
            if (checkIn.Date != checkOut.Date)
                Console.WriteLine("Phụ thu qua đêm: 30,000 VND");
            Console.WriteLine($"TỔNG PHÍ ĐỖ XE: {fee:N0} VND");
        }
        static void Bai14()
        {
            int value;
            string input;

            while (true)
            {
                Console.Write("Nhập chuỗi số: ");
                input = Console.ReadLine() ?? "";

                if (int.TryParse(input, out value))
                {
                    break;
                }

                Console.WriteLine("LỖI: Chuỗi nhập vào không phải số nguyên hợp lệ. Vui lòng nhập lại!\n");
            }

            Console.WriteLine($"Kiểm tra Parse: Thành công! Giá trị int = {value}");

            if (value >= byte.MinValue && value <= byte.MaxValue)
                Console.WriteLine($"Phù hợp kiểu byte: Có (Vừa vặn trong dải {byte.MinValue}-{byte.MaxValue})");
            else if (value >= short.MinValue && value <= short.MaxValue)
                Console.WriteLine($"Phù hợp kiểu short: Có (Vừa vặn trong dải {short.MinValue} đến {short.MaxValue})");
            else
                Console.WriteLine("Phù hợp kiểu byte/short: Không");

            int sumDigits = 0;
            string sumDetail = "";
            foreach (char c in input)
            {
                if (char.IsDigit(c))
                {
                    int digit = c - '0';
                    sumDigits += digit;
                    sumDetail += digit + " + ";
                }
            }
            if (sumDetail.EndsWith(" + "))
                sumDetail = sumDetail.Substring(0, sumDetail.Length - 3);

            Console.WriteLine($"Tổng các chữ số: {sumDetail} = {sumDigits}");

            try
            {
                checked
                {
                    int result = value * value;
                    Console.WriteLine("Kiểm tra Tràn số: An toàn trong phạm vi Int32.");
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Kiểm tra Tràn số: LỖI! Xảy ra OverflowException.");
            }
        }
        //Bài 15
        enum CustomerType
        {
            Child,
            Student,
            Adult,
            Senior
        }

        static DayOfWeek ParseDayOfWeek(string input)
        {
            if (string.IsNullOrWhiteSpace(input)) return DayOfWeek.Monday;

            string cleanInput = input.Trim().ToLower();

            return cleanInput switch
            {
                "monday" or "mon" or "2" or "thu 2" or "thứ 2" or "t2" => DayOfWeek.Monday,
                "tuesday" or "tue" or "3" or "thu 3" or "thứ 3" or "t3" => DayOfWeek.Tuesday,
                "wednesday" or "wed" or "4" or "thu 4" or "thứ 4" or "t4" => DayOfWeek.Wednesday,
                "thursday" or "thu" or "5" or "thu 5" or "thứ 5" or "t5" => DayOfWeek.Thursday,
                "friday" or "fri" or "6" or "thu 6" or "thứ 6" or "t6" => DayOfWeek.Friday,
                "saturday" or "sat" or "7" or "thu 7" or "thứ 7" or "t7" => DayOfWeek.Saturday,
                "sunday" or "sun" or "8" or "chu nhat" or "chủ nhật" or "cn" => DayOfWeek.Sunday,
                _ => DayOfWeek.Monday
            };
        }
        static decimal CalculateTicketPrice(CustomerType customer, DayOfWeek day, bool hasStudentCard, out decimal discount, out decimal surcharge)
        {
            decimal basePrice = 100000m;
            discount = 0;
            surcharge = 0;

            if (customer == CustomerType.Child || customer == CustomerType.Senior)
                discount += basePrice * 0.5m;

            if (customer == CustomerType.Student && hasStudentCard &&
                (day >= DayOfWeek.Monday && day <= DayOfWeek.Thursday))
                discount += basePrice * 0.3m;

            if (customer == CustomerType.Adult && day == DayOfWeek.Wednesday)
                discount += basePrice * 0.2m;

            if (day == DayOfWeek.Friday || day == DayOfWeek.Saturday || day == DayOfWeek.Sunday)
                    surcharge += 20000m;

            return basePrice - discount + surcharge;
        }

        static void Bai15()
        {
            Console.Write("Nhập loại khách hàng (Child/Student/Adult/Senior): ");
            string typeInput = Console.ReadLine() ?? "Adult";
            CustomerType customer = (CustomerType)Enum.Parse(typeof(CustomerType), typeInput, true);

            Console.Write("Có thẻ sinh viên hợp lệ? (true/false): ");
            bool hasStudentCard = bool.Parse(Console.ReadLine() ?? "false");

            Console.Write("Nhập ngày xem phim (Thứ 2 - Chủ Nhật / Monday - Sunday): ");
            string dayInput = Console.ReadLine() ?? "";
            DayOfWeek day = ParseDayOfWeek(dayInput);

            // Tính giá vé trực tiếp
            decimal discount, surcharge;
            decimal finalPrice = CalculateTicketPrice(customer, day, hasStudentCard, out discount, out surcharge);

            // In hóa đơn trực tiếp
            Console.WriteLine("\n--- HÓA ĐƠN VÉ XEM PHIM ---");
            Console.WriteLine("Giá vé gốc: 100,000 VND");
            Console.WriteLine($"Tổng giảm giá: -{discount:N0} VND");
            Console.WriteLine($"Phụ thu cuối tuần: {surcharge:N0} VND");
            Console.WriteLine($"TỔNG TIỀN VÉ: {finalPrice:N0} VND");
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;
            Bai1();
            Bai2();
            Bai3();
            Bai4();
            Bai5();
            Bai6();
            Bai7();
            Bai8();
            Bai9();
            Bai10();
            Bai11();
            Bai12();
            Bai13();
            Bai14();
            Bai15();
        }
    }
}
