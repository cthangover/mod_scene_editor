# Trình sửa cảnh — địa điểm của tiểu thuyết mà không cần viết JSON tay

Trình sửa cảnh là cửa sổ phía trên trò chơi đang chạy dành cho các địa điểm của tiểu thuyết hình ảnh: phông nền của cảnh, âm thanh, kịch bản mặc định và danh sách kịch bản của nó. Cảnh đã lưu được trò chơi nhận ngay, và **▶ Đến cảnh** đưa bạn tới đó, nên bạn có thể dựng một địa điểm rồi bước vào mà không cần khởi động lại.

## Cách mở

Nhấn nút búa trên thanh công cụ trong trò chơi và chọn **Trình sửa cảnh** trong hộp công cụ. Cửa sổ vẫn mở khi đổi cảnh; có thể di chuyển, đổi kích thước và đóng bằng dấu chéo.

## Một địa điểm mới

![Trình sửa cảnh với cảnh my_novel_town của mẫu tiểu thuyết được chọn: bên trái danh sách cảnh, ở giữa phông nền town_entry (cũng có trong phông nền của cảnh), bên phải Lưu vào my_novel_game và kịch bản my_novel_town của cảnh.](assets/scene-editor.jpg)

1. Nhấn **+ Cảnh mới**, gõ id của cảnh (chữ Latinh, chữ số và `_`; `switch_scene` và phần đầu kịch bản tham chiếu tới nó) và chọn mod trong **Lưu vào**.
2. Chọn một phông nền trong danh sách và nhấn **+ Thêm phông nền vào cảnh** (hoặc nhấp đúp). Một cảnh có thể có nhiều phông nền; khi vào sẽ chọn ngẫu nhiên một cái.
3. Chọn **Âm thanh** (nút phát cho phép nghe thử) và nếu muốn, **Kịch bản mặc định**, chạy khi cảnh không còn kịch bản nào khác.
4. **Lưu** (Ctrl+S) ghi `scenes/<id>.json` vào mod đã chọn.
5. **+ Kịch bản mới** tạo tệp kịch bản của cảnh này trong mod đã chọn. Khi có `scenario_editor`, tệp mở ngay ở đó; **Mở** (hoặc nhấp đúp) mở một kịch bản có sẵn của cảnh.
6. **▶ Đến cảnh** kết thúc hội thoại đang chạy và vào cảnh.

## Tệp của ai được ghi

Một cảnh là tổng các tệp `scenes/<id>.json` của mọi mod. Trình sửa chỉ ghi tệp của mod được chọn trong **Lưu vào**, và chỉ chọn được mod cài dạng thư mục. Phông nền và thiết lập đến từ tệp của mod khác được hiển thị bị khóa; sửa cảnh của người khác sẽ tạo trong mod của bạn một tệp bổ sung cho nó. **Xóa** chỉ xóa tệp của mod đã chọn.

## Khi có trục trặc

- **Nút Mở bị mờ.** Chưa cài trình sửa kịch bản; thêm `scenario_editor` (hoặc bộ Công cụ phát triển). Vẫn tạo được tệp kịch bản mới.
- **Lưu vào không có mod nào.** Chỉ ghi được vào mod dạng thư mục; mod `.zip` đóng gói chỉ đọc.
- **Phông nền hay âm thanh mới không có trong danh sách.** Nhấn **Quét lại** sau khi thêm tệp vào mod.

## Phụ thuộc

`tools_base`, `scenario_tools_base`, `dialog_base`, `ui_base`. Tùy chọn: `scenario_editor` cho nút **Mở**.
Gói cũ `editor_tools` cài mod này cùng các cửa sổ tác giả khác.
