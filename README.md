# LVTN
Luận văn tốt nghiệp, REACT - .NET  
Link truy cập website client:  https://luanvantotnghiep.netlify.app/  
Link truy cập website admin:  https://luanvantotnghiepadmin.netlify.app/
| Client |             |              |                          |
|--------|-------------|--------------|--------------------------|
|        | **Account** | **Password** |       **Username**       |
|        | 0343679935  | 123          | Bùi Lê Hoàng Nhật Trường |
|        | 0786266752  | 123          | Trần Tuấn Vũ             |
|        | 0854863505  | 123          | Nguyễn Trọng Trí         |
| Server |             |              |                          |
|        | 456         | 456          | Nguyễn Trọng Trí(admin)  |  
## 2.Hướng dẫn sử dụng  
Truy cập vào link chứa source code: https://github.com/NhatTruong-dotnet/LVTN
#### &ensp;2.1 Deploy to host client  
&ensp;&ensp;&ensp;2.1.1. Truy cập vào source code server và Fork: https://github.com/NhatTruong-dotnet/LVTN  
&ensp;&ensp;&ensp;2.1.2. Mở VScode và truy cập vào thư mục source code  
&ensp;&ensp;&ensp;2.1.3. Mở terminal và gõ lệnh npm run build  ![image](https://user-images.githubusercontent.com/66171634/182862801-7f055dd9-44bd-445e-9a00-3d50fe2bd67d.png)  
&ensp;&ensp;&ensp;2.1.4. Cấu trúc thư mục build    ![image](https://user-images.githubusercontent.com/66171634/182863082-09239f71-a086-4cfd-967e-2bf7cc1cbe54.png)  
&ensp;&ensp;&ensp;2.1.5. Truy cập vào netlify https://www.netlify.com/  
&ensp;&ensp;&ensp;2.1.6. Sau khi đăng nhập vào netlify chọn Add new site -> Deploy manual  ![image](https://user-images.githubusercontent.com/66171634/182864225-e45316b3-ab76-44fc-8cd2-6c697a5db859.png)  
&ensp;&ensp;&ensp;2.1.7. Kéo thả thư mục build vào  ![image](https://user-images.githubusercontent.com/66171634/182864658-fd5487fc-2ddc-4030-96a0-195152ccfbce.png)  
&ensp;&ensp;&ensp;2.1.8. Đợi site deploy  ![image](https://user-images.githubusercontent.com/66171634/182865246-ad502583-d933-4aba-b133-e610c200e20f.png)  
#### &ensp;2.2 Deploy to host server  
&ensp;&ensp;&ensp;2.2.1. Truy cập vào source code server và Fork: https://github.com/NhatTruong-dotnet/LVTN  
&ensp;&ensp;&ensp;2.2.2. Truy cập vào azure portal: https://portal.azure.com/#home  
&ensp;&ensp;&ensp;&ensp;2.2.2.1 Tạo mới một resource ![image](https://user-images.githubusercontent.com/55442462/180612125-70a81756-bfda-4a28-9aed-29538e44e4b6.png)  
&ensp;&ensp;&ensp;&ensp;2.2.2.2 Tạo một web app ![image](https://user-images.githubusercontent.com/55442462/180612171-e42a0009-823b-4bf4-9222-49492cab6899.png)
&ensp;&ensp;&ensp;&ensp;2.2.2.3 Điền thông tin vào (1*) và (2*), sau khi điền thông tin thì nhấn Next![image](https://user-images.githubusercontent.com/55442462/180612372-1bd83f91-0943-4e51-9307-ccf70e443f53.png)
&ensp;&ensp;&ensp;&ensp;2.2.2.4 Chọn các thông tin như hình, sau đó nhấn Review + Create![image](https://user-images.githubusercontent.com/55442462/180612605-7203943d-14e0-486e-8a48-2f78bc8d1f5a.png)  
&ensp;&ensp;&ensp;&ensp;2.2.2.5 Sau khi process thành công thì web server sẽ được hiển thị ở link (1*).azurewebsites.net  
#### &ensp;2.3 Deploy Database to Azure SQL database  
&ensp;&ensp;&ensp;2.3.1. Truy cập vào link và tải script về: https://github.com/NhatTruong-dotnet/LVTN/tree/publish/DB  
&ensp;&ensp;&ensp;2.3.2. Truy cập vào azure portal để tạo SQL Database: https://portal.azure.com/#create/Microsoft.SQLDatabase  
&ensp;&ensp;&ensp;2.3.3. Điền DB name sau đó chọn Next ![image](https://user-images.githubusercontent.com/55442462/180627478-35081b74-e021-4003-a8ee-4cd6716f25b4.png)  
&ensp;&ensp;&ensp;2.3.4. Điền thông tin như hình và nhấn Review + Create ![image](https://user-images.githubusercontent.com/55442462/180627513-aa057245-6cb0-441e-a2a4-f5aaf1c52384.png)  
&ensp;&ensp;&ensp;2.3.5. Sau khi tạo thành công DB, truy cập vào DB, chọn query editor và open query để tiến hành tạo DB ![image](https://user-images.githubusercontent.com/55442462/180627637-287daa11-7119-42f9-a73e-7c891b6a6f44.png)
&ensp;&ensp;&ensp;2.3.6. Sau khi query thành công, tiến hành kiểm tra lại các tables ![image](https://user-images.githubusercontent.com/55442462/180627651-4a2af79c-cc37-460d-ad19-cf068f814ad9.png)



