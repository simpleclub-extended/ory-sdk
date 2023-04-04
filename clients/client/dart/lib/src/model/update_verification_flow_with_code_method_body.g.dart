// GENERATED CODE - DO NOT MODIFY BY HAND

part of 'update_verification_flow_with_code_method_body.dart';

// **************************************************************************
// BuiltValueGenerator
// **************************************************************************

class _$UpdateVerificationFlowWithCodeMethodBody
    extends UpdateVerificationFlowWithCodeMethodBody {
  @override
  final String? code;
  @override
  final String? csrfToken;
  @override
  final String? email;
  @override
  final String? flow;
  @override
  final String? method;

  factory _$UpdateVerificationFlowWithCodeMethodBody(
          [void Function(UpdateVerificationFlowWithCodeMethodBodyBuilder)?
              updates]) =>
      (new UpdateVerificationFlowWithCodeMethodBodyBuilder()..update(updates))
          ._build();

  _$UpdateVerificationFlowWithCodeMethodBody._(
      {this.code, this.csrfToken, this.email, this.flow, this.method})
      : super._();

  @override
  UpdateVerificationFlowWithCodeMethodBody rebuild(
          void Function(UpdateVerificationFlowWithCodeMethodBodyBuilder)
              updates) =>
      (toBuilder()..update(updates)).build();

  @override
  UpdateVerificationFlowWithCodeMethodBodyBuilder toBuilder() =>
      new UpdateVerificationFlowWithCodeMethodBodyBuilder()..replace(this);

  @override
  bool operator ==(Object other) {
    if (identical(other, this)) return true;
    return other is UpdateVerificationFlowWithCodeMethodBody &&
        code == other.code &&
        csrfToken == other.csrfToken &&
        email == other.email &&
        flow == other.flow &&
        method == other.method;
  }

  @override
  int get hashCode {
    var _$hash = 0;
    _$hash = $jc(_$hash, code.hashCode);
    _$hash = $jc(_$hash, csrfToken.hashCode);
    _$hash = $jc(_$hash, email.hashCode);
    _$hash = $jc(_$hash, flow.hashCode);
    _$hash = $jc(_$hash, method.hashCode);
    _$hash = $jf(_$hash);
    return _$hash;
  }

  @override
  String toString() {
    return (newBuiltValueToStringHelper(
            r'UpdateVerificationFlowWithCodeMethodBody')
          ..add('code', code)
          ..add('csrfToken', csrfToken)
          ..add('email', email)
          ..add('flow', flow)
          ..add('method', method))
        .toString();
  }
}

class UpdateVerificationFlowWithCodeMethodBodyBuilder
    implements
        Builder<UpdateVerificationFlowWithCodeMethodBody,
            UpdateVerificationFlowWithCodeMethodBodyBuilder> {
  _$UpdateVerificationFlowWithCodeMethodBody? _$v;

  String? _code;
  String? get code => _$this._code;
  set code(String? code) => _$this._code = code;

  String? _csrfToken;
  String? get csrfToken => _$this._csrfToken;
  set csrfToken(String? csrfToken) => _$this._csrfToken = csrfToken;

  String? _email;
  String? get email => _$this._email;
  set email(String? email) => _$this._email = email;

  String? _flow;
  String? get flow => _$this._flow;
  set flow(String? flow) => _$this._flow = flow;

  String? _method;
  String? get method => _$this._method;
  set method(String? method) => _$this._method = method;

  UpdateVerificationFlowWithCodeMethodBodyBuilder() {
    UpdateVerificationFlowWithCodeMethodBody._defaults(this);
  }

  UpdateVerificationFlowWithCodeMethodBodyBuilder get _$this {
    final $v = _$v;
    if ($v != null) {
      _code = $v.code;
      _csrfToken = $v.csrfToken;
      _email = $v.email;
      _flow = $v.flow;
      _method = $v.method;
      _$v = null;
    }
    return this;
  }

  @override
  void replace(UpdateVerificationFlowWithCodeMethodBody other) {
    ArgumentError.checkNotNull(other, 'other');
    _$v = other as _$UpdateVerificationFlowWithCodeMethodBody;
  }

  @override
  void update(
      void Function(UpdateVerificationFlowWithCodeMethodBodyBuilder)? updates) {
    if (updates != null) updates(this);
  }

  @override
  UpdateVerificationFlowWithCodeMethodBody build() => _build();

  _$UpdateVerificationFlowWithCodeMethodBody _build() {
    final _$result = _$v ??
        new _$UpdateVerificationFlowWithCodeMethodBody._(
            code: code,
            csrfToken: csrfToken,
            email: email,
            flow: flow,
            method: method);
    replace(_$result);
    return _$result;
  }
}

// ignore_for_file: deprecated_member_use_from_same_package,type=lint
