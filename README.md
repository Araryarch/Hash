| Nama                 | NRP        |
| -------------------- | ---------- |
| Ararya Arka Anugraha | 5053241050 |

---

**1. Apa itu Hash dalam struktur data?**
Hash adalah metode untuk mengatur data dengan kode unik (hash code) agar cepat disimpan dan dicari.

---

**2. Apa itu Hash Function? Apa jenis dan contohnya?**
Hash Function mengubah data jadi hash code.
**Jenis & Contoh:**

- **Division**: 123 ÷ 10 = 3.
- **Multiplication**: 123 × 0,618 = 83.
- **Folding**: 1234 → 12 + 34 = 46 ÷ 10 = 6.
- **Mid-Square**: 123² = 15129 → 12.

---

**3. Apa itu Hash Table?**
Hash Table adalah struktur data yang menyimpan data berdasarkan hash code dari hash function.

---

**4. Bagaimana alur menyimpan dan mencari data dengan Hash? Beri contoh!**

- **Menyimpan**: Data diubah jadi hash code, disimpan di indeks itu. Contoh: "Hu Tao" → hash code 5, simpan di indeks 5.
- **Mencari**: Hitung hash code, cek indeks. Contoh: "Hu Tao" → hash code 5, ambil data dari indeks 5.

---

**5. Bagaimana cara atasi collision dengan Chaining Method? Beri contoh!**
**Collision**: Dua data punya hash code sama.
**Chaining**: Simpan data di Linkedlist pada indeks sama.
**Contoh**: "Hu Tao" dan "Furina" hash code 5, simpan keduanya di Linkedlist indeks 5.

---

**6. Bagaimana cara atasi collision dengan Open Addressing (Linear Probing, Quadratic Probing, Double Hashing)? Beri contoh!**

- **Linear Probing**: Indeks penuh, coba indeks berikutnya. Contoh: Indeks 5 penuh, coba 6.
- **Quadratic Probing**: Loncat kuadrat (1, 4, 9). Contoh: Indeks 5 penuh, coba 5+1²=6, lalu 5+2²=9.
- **Double Hashing**: Gunakan hash kedua untuk loncatan. Contoh: Indeks 5 penuh, hash kedua = 3, coba 5+3=8.

---

**7. Apa manfaat dan kekurangan Hash?**
**Manfaat**: cepat menyimpan, cari, hapus (O(1)) karena pakai Linkedlist.
**Kekurangan**: Collision, butuh hash function baik, memori besar.

---

**8. Bagaimana analisis asimptotik Hash untuk insert, delete, dan retrieve?**

- **Insert**: O(1), worst case: O(n).
- **Delete**: O(1), worst case: O(n).
- **Retrieve**: O(1), worst case: O(n).

---

**9.Buatlah kodingan untuk menunjukkan implementasi struktur data hash pada saat insert dan get data dengan metode collision resolution menggunakan chaining method**

- ada di code class `ChainedHashTable`

---

**10. Buatlah kodingan untuk menunjukkan implementasi struktur data hash pada saat insert dan get data dengan metode collision resolution menggunakan open addresing method (Linear Probing, Quadratic Probing, Double Hashing)**

- ada di code class `OpenAdressing`
