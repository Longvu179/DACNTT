import axios from "axios";
import { useState } from "react";
import { Link, useNavigate } from "react-router-dom";

const RegisterForm = () => {
	const [formData, setFormData] = useState({
		email: "",
		username: "",
		password: "",
		confirmPassword: "",
	});

	const [message, setMessage] = useState("");
	const [loading, setLoading] = useState(false);
	const navigate = useNavigate();

	const handleChange = (e) => {
		const { name, value } = e.target;
		setFormData((prevState) => ({
			...prevState,
			[name]: value,
		}));
	};

	const handleSubmit = async (e) => {
		e.preventDefault();
		if (formData.password !== formData.confirmPassword) {
			setMessage("Mật khẩu không khớp!");
			return;
		}

		setLoading(true);
		const encodedLink = encodeURIComponent(
			window.location.origin + "/confirm-email-register"
		);

		try {
			await axios.post(`/Auth/register?url=${encodedLink}`, {
				username: formData.username,
				email: formData.email,
				password: formData.password,
			});

			setMessage("Đăng ký thành công! Vui lòng kiểm tra email.");

			setTimeout(() => {
				navigate("/login", {
					state: {
						successMessage:
							"Đăng ký thành công! Vui lòng kiểm tra email để xác thực trước khi đăng nhập.",
					},
				});
				setLoading(false);
			}, 2000);
		} catch (error) {
			console.log(error);
			setMessage("Đăng ký thất bại. Vui lòng thử lại!");
			setLoading(false);
		}
	};

	return (
		<div className="min-h-screen w-full flex bg-[#39B7CD] relative overflow-hidden">
			{/* Overlay Loading */}
			{loading && (
				<div className="absolute inset-0 bg-black/50 backdrop-blur-md flex justify-center items-center z-50">
					<div className="w-16 h-16 border-4 border-white border-t-transparent rounded-full animate-spin"></div>
				</div>
			)}

			{/* Left Section */}
			<div className="flex-1 p-8 relative text-gray-800 flex flex-col z-10">
				<div>
					<a
						href="/"
						className="text-gray-800 inline-flex items-center mt-8 hover:opacity-80 transition-opacity"
					>
						← Trang chủ
					</a>
				</div>
				<div className="flex flex-col justify-center items-center h-full">
					<img
						src="/LogPhone.png"
						alt="LogPhone Logo"
						className="w-[200px] h-[200px] object-contain mb-6"
					/>
					<p className="text-lg leading-relaxed w-[40%] text-center">
						Đăng ký ngay để nhận được nhiều khuyến mãi đặc biệt
					</p>
				</div>
			</div>

			{/* Right Section */}
			<div className="flex-1 flex justify-center items-center p-8">
				<div className="bg-[#333333] backdrop-blur-lg p-8 rounded-lg w-full max-w-[400px]">
					<h2 className="text-white text-xl font-semibold mb-6 text-center">
						Đăng ký tài khoản
					</h2>
					<form
						onSubmit={handleSubmit}
						className="flex flex-col gap-4"
					>
						<input
							type="email"
							name="email"
							placeholder="Email"
							value={formData.email}
							onChange={handleChange}
							className="p-3 rounded-md border-none bg-white focus:outline-none focus:ring-2 focus:ring-white/50"
							required
						/>
						<input
							type="text"
							name="username"
							placeholder="Tên đăng nhập"
							value={formData.username}
							onChange={handleChange}
							className="p-3 rounded-md border-none bg-white focus:outline-none focus:ring-2 focus:ring-white/50"
							required
						/>
						<input
							type="password"
							name="password"
							placeholder="Mật khẩu"
							value={formData.password}
							onChange={handleChange}
							className="p-3 rounded-md border-none bg-white focus:outline-none focus:ring-2 focus:ring-white/50"
							required
						/>
						<input
							type="password"
							name="confirmPassword"
							placeholder="Xác nhận mật khẩu"
							value={formData.confirmPassword}
							onChange={handleChange}
							className="p-3 rounded-md border-none bg-white focus:outline-none focus:ring-2 focus:ring-white/50"
							required
						/>

						{/* Nút đăng ký hiển thị loading */}
						<button
							type="submit"
							disabled={loading}
							className={`p-3 bg-gradient-to-r from-[#2193B0] to-[#6DD5ED] text-black rounded-md font-medium cursor-pointer transition-colors mt-2
							${loading ? "opacity-50 cursor-not-allowed" : "hover:opacity-90"}`}
						>
							{loading ? "Đang xử lý..." : "Đăng ký"}
						</button>
					</form>
					<p className="text-center mt-4 text-white">
						Đã có tài khoản?{" "}
						<Link
							to="/login"
							className="underline hover:opacity-80 transition-opacity"
						>
							Đăng nhập
						</Link>
					</p>
					<p className="text-center mt-4 text-red-500">{message}</p>
				</div>
			</div>
		</div>
	);
};

export default RegisterForm;
