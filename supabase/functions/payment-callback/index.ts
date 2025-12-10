// supabase/functions/payment-callback/index.ts
import { serve } from "https://deno.land/std/http/server.ts";
import { createClient } from "https://esm.sh/@supabase/supabase-js";

// Tạo client với quyền service role để ghi dữ liệu vào DB
const supabase = createClient(
  Deno.env.get("https://qyhamranljmfsrxfxfls.supabase.co")!,
  Deno.env.get("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJpc3MiOiJzdXBhYmFzZSIsInJlZiI6InF5aGFtcmFubGptZnNyeGZ4ZmxzIiwicm9sZSI6InNlcnZpY2Vfcm9sZSIsImlhdCI6MTc2MTQ2ODMzNCwiZXhwIjoyMDc3MDQ0MzM0fQ.DaDBscqR8J0NrCnOMZZHOfq9LyKqtbM6odoyFIZxAFs")!
);

serve(async (req) => {
  try {
    const body = await req.json();

    // Callback từ SePay/MB Bank:
    // {
    //   "status": "success",
    //   "amount": 100000,
    //   "description": "VE-20251208-001",   // chính là mã vé
    //   "transactionId": "MB20251208153001",
    //   ...
    // }
	console.log("SUPABASE_URL:", Deno.env.get("SUPABASE_URL"));
    if (body.status === "success") {
      const ticketId = body.description; // mã vé truyền trong nội dung chuyển khoản
      const amount = body.amount;

      // Cập nhật vé sang trạng thái "paid"
      const { error } = await supabase
        .from("ve")
        .update({
          TrangThai: "paid",
          GiaVe: amount,
          NgayDat: new Date().toISOString(),
          // Nếu bạn đã thêm cột TransactionId thì có thể lưu thêm:
          // TransactionId: body.transactionId,
        })
        .eq("IdVe", ticketId);

      if (error) {
        console.error("Error updating ticket:", error.message);
        return new Response(
          JSON.stringify({ status: "error", message: error.message }),
          { status: 500 }
        );
      }

      return new Response(
        JSON.stringify({ status: "paid", IdVe: ticketId }),
        { status: 200 }
      );
    }

    return new Response(JSON.stringify({ status: "failed" }), { status: 400 });
  } catch (err) {
    console.error("Callback error:", err);
    return new Response(
      JSON.stringify({ status: "error", message: err.message }),
      { status: 500 }
    );
  }
});
